--Write SQL commands to accomplish the requirements listed below. Put all the sql commands into a text or sql file, put your name into the filename and upload it here.

--Create a database called SIIT_DB

--Create a table called Students in SIIT_DB with the following columns: StudentID autoincremented Primary Key, Name nvarchar, Profession nvarchar, CourseID int

--Create a table called Courses in SIIT_DB with the following columns: CourseID autoincremented Primary Key, Name nvarchar, Duration int, TeacherID int

--Create a table called Teachers in SIIT_DB with the following columns: TeacherID autoincremented Primary Key, Name nvarchar

--Insert at least 10 rows into the Students table, at lest 2 rows into the Course table and at least 2 rows into the Teachers course

CREATE DATABASE SIIT_DB
GO

USE SIIT_DB;
GO


CREATE TABLE Students(
StudentID INT IDENTITY(1,1) PRIMARY KEY,
Name NVARCHAR(100),
Profession NVARCHAR(100),
CourseID INT
);
GO

CREATE TABLE Courses(
CourseID INT IDENTITY(1,1) PRIMARY KEY,
Name NVARCHAR(100),
Duration NVARCHAR(100),
TeacherID INT
);
GO

CREATE TABLE Teachers(
TeacherID INT IDENTITY(1,1) PRIMARY KEY,
Name NVARCHAR(100),
);
GO

INSERT INTO Students (Name, Profession, CourseID) VALUES 
('John Doe', 'Engineering', 1),
('Jane Smith', 'Medicine', 2),
('Alice Johnson', 'Law', 1),
('Bob Brown', 'Engineering', 1),
('Charlie Davis', 'Computer Science', 2),
('Eve White', 'Business', 1),
('Frank Green', 'Engineering', 1),
('Grace Miller', 'Medicine', 2),
('Hank Wilson', 'Law', 1),
('Ivy Moore', 'Computer Science', 2);
GO

INSERT INTO Courses (Name, Duration, TeacherID) VALUES 
('Engineering', 4, 1),
('Medicine', 6, 2);
GO

INSERT INTO Teachers (Name) VALUES 
('Dr. Smith'),
('Prof. Johnson');
GO