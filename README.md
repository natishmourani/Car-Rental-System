# Car Rental System  

## Overview  
This is a **desktop-based Car Rental Management System** developed in **C# (.NET Framework, Windows Forms)** with **SQL Server** as the database.  

It provides an easy way to manage car rentals, customers, and returns. The system also calculates delays, fines, and total amounts automatically when cars are returned.  

---

##  Features  
-  Manage **Cars** (Add, Update, Delete, View)  
-  Manage **Customers** (Add, Update, Delete, View)  
-  Rent cars and record details  
-  Handle **Returns** with:  
  - Delay calculation  
  - Fine calculation (PKR 1500 per day)  
  - Automatic total amount updates  
-  Mark cars as available/unavailable  
-  Validation & constraints (no negative inputs, admin account cannot be deleted, return date must be after rental date)  
-  Database integration with SQL Server  
-  ER Diagram & Class Diagram included  

---

##  Project Structure  

```
Car-Rental-System/
│── Applications/
│   ├── CarRentalSystem.sln
│   └── Car Rental System/
│       ├── Program.cs
│       ├── CarForm.cs
│       ├── CustomerForm.cs
│       ├── RentalForm.cs
│       ├── ReturnForm.cs
│       ├── Properties/
│       │   ├── Resources.Designer.cs
│       │   ├── Resources.resx
│
│── Database/
│   ├── CarRentalSysten.sql
│   ├── ER_Diagram.png
│   └── Class_Diagram.png
│
│── README.md

```

---

## Technologies Used  
- **C# (.NET Framework, Windows Forms)**  
- **SQL Server** (Database)  
- **Visual Studio 2022**  

---

##  How to Run  
1. Clone the repository or download the ZIP.  
2. Open the solution (`CarRentalSystem.sln`) in **Visual Studio 2022**.  
3. Restore the database using the provided `CarRentalSystem.sql` file in SQL Server.  
4. Update the database connection string if needed.  
5. Run the project from Visual Studio.  

---


## Author  
- Natish  
