# Skills International School - Student Management System
<img width="1156" height="857" alt="Screenshot 2026-07-08 003632" src="https://github.com/user-attachments/assets/608d1030-805d-4f10-a93f-37dbce1e1b52" />


A robust and secure desktop application designed for managing student records at Skills International School. This system features a secure login interface and complete CRUD (Create, Read, Update, Delete) functionality, seamlessly integrated with a Microsoft SQL Server database.

## 🚀 Features

- **Secure Authentication:** Institutional access control via a dedicated Login Form (Default Credentials: Username: `Admin` / Password: `Skills@123`).
- **Student Registration:** Seamlessly capture comprehensive student records including Basic Details, Contact Details, and Parent/Guardian Information.
- **Advanced Search:** Quick retrieval of student records directly from the database using a dynamic Registration Number (`regNo`) dropdown.
- **Complete CRUD Operations:** Easily register new students, update existing profiles, or delete records with automated database synchronization.
- **Data Validation & Safety:** Integrated confirmation dialogue boxes for critical actions like deleting records or exiting the application to prevent data loss.

## 🛠️ Tech Stack

- **Frontend / GUI:** C# (.NET Framework Windows Forms Application)
- **IDE:** Microsoft Visual Studio
- **Database:** Microsoft SQL Server Management Studio (SSMS)
- **Data Access Technology:** ADO.NET (SqlConnection, SqlCommand, SqlDataReader)

## 📦 Database Configuration

To set up the database backend, open SQL Server Management Studio (SSMS) and execute the following T-SQL script to initialize the `Student` database and the `Registration` table:

``sql
CREATE DATABASE Student;
GO

USE Student;
GO

CREATE TABLE Registration (
    regNo INT PRIMARY KEY,
    firstName VARCHAR(50) NULL,
    lastName VARCHAR(50) NULL,
    dateOfBirth DATETIME NULL,
    gender VARCHAR(50) NULL,
    address VARCHAR(50) NULL,
    email VARCHAR(50) NULL,
    mobilePhone INT NULL,
    homePhone INT NULL,
    parentName VARCHAR(50) NULL,
    nic VARCHAR(50) NULL,
    contactNo INT NULL
);
GO

⚙️ Installation & Setup  
Clone the Repository:  

Bash
git clone [https://github.com/charithwannisingha/Student-Management-System-CSharp.git](https:/charithwannisingha/github.com//YOUR_REPOSITORY_NAME.git)
Database Deployment:

Execute the SQL setup script provided above in your local SSMS instance.

Open Project:

Open Microsoft Visual Studio.

Select Open a project or solution and choose your .sln file.

Update Connection String:

Locate the database connection initialization block in RegisterForm.cs.

Update the connection string to match your local SQL Server instance name:

C#
string connectionString = @"Data Source=YOUR_SERVER_NAME;Initial Catalog=Student;Integrated Security=True";
Build and Run:

Press F5 or click Start in Visual Studio to compile and run the application.

👨‍💻 Developer
Name: Charith Wannisingha
