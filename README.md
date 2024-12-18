# Student Database Management System
This project is an ASP.NET Core Razor Pages application connected to MS SQL database. It enables the management of students and courses with functionality to create, read, update and delete entries (CRUD).

# Features
Home Page:
The landing page of the application.

New Student Page:
In this page, information of the new students are shown via database. Also you can add a new student to the system, edit or delete. 

New Course Page:
New courses derived from the database are shown with each course's name and a lecturer's name. This page can also perform CRUD operations.

Student Information Page:
This page is connected to the New Student page, displaying all the students along with their associated course details. When the New Student page is edited, this page automatically updates, displaying the following information: 
- Student ID
- Student Name
- City
- Course Name

# Database Structure
The databse consists of 2 tables: Courses and Students. It contains one-to-many relationship where a course can have many students, while each student has one course.

Table description:
1. Courses Table -
- CourseId: Primary key
- CourseName: name of the course
- Lecturer: name of the lecturer
  
2. Students Table -
- StudentId: Primary key
- StudnetName: student's name
- City: city of residence
- CourseId: Foreign key referencing the Courses table
  
# Setup
Technologies Used:
- ASP.NET Core 8.0 for creating Razor Pages.
- Entity Framework Core for database access.
- Ms SQL Server for database storage.

Prerequisites:
- Visual Studio
- MS SQL Server
- MS SQL Server Management Studio

How to run the application:
1. Clone the Repository. 
2. Restore the database in SQL Server Management Studio.
   - database backup file (.bak) can be found inside Database Backup folder
3. Run the Application in Visual Studio.

# Additional Considerations
Answers to Q2 part iv is in the folder: Question2-SQL Queries
