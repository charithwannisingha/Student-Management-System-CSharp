-- ============================================================================
-- Skills International School - Student Management System
-- Database Setup Script
-- ============================================================================
-- Instructions:
-- 1. Open Microsoft SQL Server Management Studio (SSMS).
-- 2. Connect to your SQL Server instance.
-- 3. Run this entire script (press F5 or click Execute).
-- 4. The script will create the database and table if they do not already exist.
-- ============================================================================

-- Drop the database if it already exists (use with caution in production)
USE [master];
GO

IF DB_ID('Student') IS NOT NULL
BEGIN
    ALTER DATABASE [Student] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [Student];
END
GO

-- Create the Student database
CREATE DATABASE [Student];
GO

-- Switch to the newly created database
USE [Student];
GO

-- ============================================================================
-- Table: Registration
-- Stores all student registration records for Skills International School.
-- ============================================================================
IF OBJECT_ID('dbo.Registration', 'U') IS NOT NULL
    DROP TABLE dbo.Registration;
GO

CREATE TABLE dbo.Registration
(
    regNo       INT           PRIMARY KEY,                 -- Unique student registration number
    firstName   VARCHAR(50)   NOT NULL,                     -- Student first name
    lastName    VARCHAR(50)   NOT NULL,                     -- Student last name
    dateOfBirth DATETIME      NOT NULL,                     -- Student date of birth
    gender      VARCHAR(50)   NOT NULL,                     -- Gender (Male / Female)
    address     VARCHAR(50)   NOT NULL,                     -- Residential address
    email       VARCHAR(50)   NOT NULL,                     -- Email address
    mobilePhone INT           NOT NULL,                     -- Mobile phone number
    homePhone   INT           NOT NULL,                     -- Home phone number
    parentName  VARCHAR(50)   NOT NULL,                     -- Parent / guardian name
    nic         VARCHAR(50)   NOT NULL,                     -- National Identity Card number
    contactNo   INT           NOT NULL                      -- Emergency contact number
);
GO

-- Optional: Insert a sample record for quick testing
-- INSERT INTO dbo.Registration (regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo)
-- VALUES (1001, 'John', 'Doe', '2005-03-15', 'Male', '123 Main Street, Colombo', 'john.doe@email.com', 771234567, 112345678, 'Richard Doe', '200512345678', 112345678);
-- GO

PRINT '============================================';
PRINT 'Database [Student] created successfully.';
PRINT 'Table [dbo].[Registration] created successfully.';
PRINT '============================================';
GO
