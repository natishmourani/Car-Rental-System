create database CarRentalSystem;
use CarRentalSystem; 

-- Users table
create table users(
    userid int,
    username varchar(100),
    password varchar(20),

    constraint userid_not_null check (userid is not null),
    constraint username_not_null check (username is not null),
    constraint password_not_null check (password is not null),
    constraint pk_userid primary key (userid)
);

--Stored procedure for adding user by validating user ID
create procedure proc_AddUser
    @userid int,
    @username varchar(100),
    @password varchar(100)
as
begin
    set nocount on;

    if exists (select 1 from users where userid = @userid)
    begin
        raiserror('User ID already exists.', 16, 1);
        return;
    end


--Trigger for preventing admin account delete
create trigger trg_preventAdminDelete
on users
after delete
as
begin

    if exists (select 1 from deleted where lower(username) = 'admin')
    begin
        rollback;

        raiserror ('Admin account cannot be deleted.', 16, 1);
    end
end


-- Cars table
--car regno datatype is varchar(10)
create table cars(
    regno int,
    brand varchar(50),
    model varchar(50),
    price int,
    available varchar(10),

    constraint regno_not_null check (regno is not null),
    constraint brand_not_null check (brand is not null),
    constraint model_not_null check (model is not null),
    constraint price_not_null check (price is not null),
    constraint available_not_null check (available is not null),
    constraint pk_regno primary key (regno)
);

--View table for available cars
create view ViewAvailableCars as
select regno, brand, model, price
from cars
where available = 'Yes'

			

-- Customers table
create table customers(
    custid int,
    custname varchar(50),
    custaddress varchar(100),
    custphone varchar(13),

    constraint custid_not_null check (custid is not null),
    constraint custname_not_null check (custname is not null),
    constraint custaddress_not_null check (custaddress is not null),
    constraint custphone_not_null check (custphone is not null),
    constraint pk_custid primary key (custid)
);


-- Rentals table
create table rentals(
    rentalid int,
    carregno int,
    custid int,
    rentaldate date,
    returndate date,
	
    constraint rentals_rentalid_not_null check (rentalid is not null),
    constraint rentals_carregno_not_null check (carregno is not null),
    constraint rentals_custid_not_null check (custid is not null),
    constraint rentals_rentaldate_not_null check (rentaldate is not null),
    constraint rentals_returndate_not_null check (returndate is not null),
    constraint pk_rentals_rentalid primary key (rentalid),
    constraint fk_rentals_carregno foreign key (carregno) references cars(regno),
    constraint fk_rentals_custid foreign key (custid) references customers(custid)
);

--View table of rentals table joined with customers table
create view ViewRentalsWithCustomers as
select
    r.rentalid, 
    r.carregno, 
    r.custid, 
    c.custname, 
    c.custaddress, 
    r.rentaldate, 
    r.returndate,
    r.totalamount
from rentals r
join customers c on r.custid = c.custid;


--Stored procdure for inserting data in rentals' table
create procedure proc_AddRental
    @rentalid int,
    @carregno varchar(50),
    @custid int,
    @rentaldate date,
    @returndate date,
    @totalamount int output
as
begin
    set nocount on;

    if exists (select 1 from rentals where rentalid = @rentalid)
    begin
        raiserror('rental id already exists.', 16, 1);
        return;
    end

    if (@returndate < @rentaldate)
    begin
        raiserror('return date must be after rental date.', 16, 1);
        return;
    end

    declare @days int = datediff(day, @rentaldate, @returndate) + 1;
    if @days <= 0
        set @days = 1;

    declare @priceperday int;
    select @priceperday = price from cars where regno = @carregno;

    set @totalamount = @priceperday * @days;

    insert into rentals (rentalid, carregno, custid, rentaldate, returndate, totalamount)
    values (@rentalid, @carregno, @custid, @rentaldate, @returndate, @totalamount);

    update cars set available = 'no' where regno = @carregno;
end


--Stored procedure for updating data in rentals' table
create procedure proc_UpdateRental
    @rentalid int,
    @carregno varchar(50),
    @custid int,
    @rentaldate date,
    @returndate date,
    @totalamount int output
as
begin
    set nocount on;

    if not exists (select 1 from rentals where rentalid = @rentalid)
    begin
        raiserror('rental id does not exist.', 16, 1);
        return;
    end

    if (@returndate < @rentaldate)
    begin
        raiserror('return date must be after rental date.', 16, 1);
        return;
    end

    declare @days int = datediff(day, @rentaldate, @returndate) + 1;
    if @days <= 0
        set @days = 1;

    declare @priceperday int;
    select @priceperday = price from cars where regno = @carregno;

    set @totalamount = @priceperday * @days;

    update rentals
    set carregno = @carregno,
        custid = @custid,
        rentaldate = @rentaldate,
        returndate = @returndate,
        totalamount = @totalamount
    where rentalid = @rentalid;
end;



--Trigger for updating car's status for rentals' upon a record deletion
create trigger trg_markcaravailableonrentaldelete
on rentals
after delete
as
begin
    set nocount on;
	
	update cars
    set available = 'Yes'
    where regno in (
        select carregno from deleted
    );
end;


-- Returns table
create table returns(
    returnid int,
    carid int,
    custid int,
    returndate date,
    delay varchar(50),
    fine int,

    constraint returns_returnid_not_null check (returnid is not null),	
    constraint returns_carid_not_null check (carid is not null),
    constraint returns_custid_not_null check (custid is not null),
    constraint returns_returndate_not_null check (returndate is not null),
    constraint returns_delay_not_null check (delay is not null),
    constraint returns_fine_not_null check (fine is not null),
    constraint pk_returns_returnid primary key (returnid),
    constraint fk_returns_carid foreign key (carid) references cars(regno),
    constraint fk_returns_custid foreign key (custid) references customers(custid)
);

--Trigger for Updating Car's status for return's table
create trigger trg_afterreturninsert
on returns
after insert
as
begin

    update cars
    set available = 'Yes'
    where regno in (
        select carid from inserted
    );

    delete from rentals
    where carregno in (
        select carid from inserted
    );
end;



--changing datatype of regno in car's table
alter table rentals drop constraint fk_rentals_carregno;
alter table returns drop constraint fk_returns_carid;

alter table cars drop constraint regno_not_null;
alter table cars drop constraint pk_regno;

alter table cars alter column regno varchar(10);

alter table rentals drop constraint rentals_carregno_not_null;
alter table returns drop constraint returns_carid_not_null;

alter table rentals alter column carregno varchar(10);
alter table returns alter column carid varchar(10);

alter table rentals add constraint rentals_carregno_not_null check (carregno is not null);
alter table returns add constraint returns_carid_not_null check (carid is not null);





