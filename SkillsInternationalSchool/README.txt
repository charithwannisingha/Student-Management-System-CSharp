================================================================================
  SKILLS INTERNATIONAL SCHOOL - STUDENT MANAGEMENT SYSTEM
  README.TXT
================================================================================

1. SYSTEM OVERVIEW
   ----------------
   Skills International School Student Management System is a C# Windows Forms
   desktop application that allows school administrators to manage student
   registrations. It provides secure login access and full CRUD (Create, Read,
   Update, Delete) operations on student records stored in a Microsoft SQL
   Server database.

   Forms Included:
     - LoginForm.cs       : Secure admin authentication
     - RegisterForm.cs    : Student registration with full CRUD operations


2. REQUIREMENTS
   -------------
   Software:
     - Microsoft Visual Studio 2017 / 2019 / 2022
       (Any edition: Community, Professional, or Enterprise)
     - .NET Framework 4.8 SDK (or 4.7.2)
     - Microsoft SQL Server (any edition):
         * SQL Server Express (free)
         * SQL Server Developer Edition
         * SQL Server Standard / Enterprise
       OR SQL Server LocalDB (bundled with Visual Studio)

   NuGet Packages (if not using System.Data.SqlClient from GAC):
     - System.Data.SqlClient  (already included in .NET Framework)


3. HOW TO SET UP THE DATABASE
   ---------------------------
   Method A - Using SQL Server Management Studio (Recommended):

     1. Open SQL Server Management Studio (SSMS).
     2. Connect to your SQL Server instance.
     3. Click File > Open > File... and select:
           "DatabaseSetup.sql"
     4. Press F5 (or click Execute) to run the entire script.
     5. You should see messages confirming the database and table creation:
           "Database [Student] created successfully."
           "Table [dbo].[Registration] created successfully."

   Method B - Using the sqlcmd command-line tool:

     1. Open Command Prompt or PowerShell as Administrator.
     2. Navigate to the folder containing DatabaseSetup.sql.
     3. Run the following command:
           sqlcmd -S .\SQLEXPRESS -E -i DatabaseSetup.sql
        (Replace ".\SQLEXPRESS" with your SQL Server instance name if different.)


4. HOW TO UPDATE THE SQL CONNECTION STRING
   -----------------------------------------
   The connection string is stored in the App.config file:
       SkillsInternationalSchool/App.config

   Locate the <connectionStrings> section and update the connectionString
   value to match your SQL Server configuration:

   Example Connection Strings:

     -- LocalDB (no installation needed, comes with Visual Studio) --
     Server=(localdb)\MSSQLLocalDB;Database=Student;Integrated Security=True;

     -- SQL Server Express using Windows Authentication --
     Server=.\SQLEXPRESS;Database=Student;Integrated Security=True;

     -- SQL Server default instance using Windows Authentication --
     Server=localhost;Database=Student;Integrated Security=True;

     -- SQL Server with SQL Authentication (sa user) --
     Server=localhost;Database=Student;User Id=sa;Password=YourPassword;

   Important: If your SQL Server uses a named instance (e.g. SQLEXPRESS),
   make sure to include the instance name after the server address.


5. HOW TO BUILD AND RUN THE PROJECT
   ----------------------------------
   1. Open Visual Studio.
   2. Click File > Open > Project/Solution.
   3. Browse to and select:
        SkillsInternationalSchool.csproj
   4. Once the project loads, ensure the connection string in App.config
      is correctly configured for your SQL Server.
   5. Press F5 (or click Start) to build and run the application.
   6. The Login Form will appear. Log in with the default admin credentials.
   7. For a release build, select "Release" configuration and click
      Build > Build Solution (Ctrl+Shift+B).


6. DEFAULT ADMIN LOGIN CREDENTIALS
   ---------------------------------
   The login credentials are hardcoded in LoginForm.cs:

       Username:  Admin
       Password:  Skills@123

   These credentials must be entered exactly as shown (case-sensitive for
   the password).

   To change the credentials, edit the following constants in LoginForm.cs:
       private const string ADMIN_USERNAME = "Admin";
       private const string ADMIN_PASSWORD = "Skills@123";


7. PROJECT FILE STRUCTURE
   ------------------------
   SkillsInternationalSchool/
   |
   |-- DatabaseSetup.sql            # T-SQL script to create the database
   |-- README.txt                   # This file
   |-- App.config                   # Application configuration (connection string)
   |-- Program.cs                   # Application entry point
   |-- LoginForm.cs                 # Login form code-behind (business logic)
   |-- LoginForm.Designer.cs        # Login form designer (UI layout)
   |-- RegisterForm.cs              # Registration form code-behind (business logic)
   |-- RegisterForm.Designer.cs     # Registration form designer (UI layout)
   |-- SkillsInternationalSchool.csproj   # C# project file
   |
   \-- (bin/ and obj/ folders are generated at build time)


8. TROUBLESHOOTING
   -----------------
   Problem: "Cannot connect to database" error on startup.
   Solution:
     - Verify SQL Server is running (check Windows Services or SSMS).
     - Confirm the connection string in App.config is correct.
     - Check that the "Student" database exists (run the SQL setup script).
     - If using SQL Authentication, ensure SQL Server allows mixed-mode auth.

   Problem: "Login failed for user" error.
   Solution:
     - If using Integrated Security, the Windows user must have access to
       SQL Server. Add your Windows account as a SQL Server login.
     - If using SQL Authentication, verify the username/password.

   Problem: "Invalid object name 'Registration'" error.
   Solution:
     - Run DatabaseSetup.sql to create the table.
     - Ensure you are connected to the correct database (Student).

================================================================================
  END OF README
================================================================================
