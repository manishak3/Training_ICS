create database CaseStudy
use CaseStudy

create table Student(
 stdID int primary key,
 stdName varchar(35),
 stdDOB Date
 )


 create table Course(
 Cid int primary key,
 Cname varchar(30)
 )
 
 create table Enrollment(
 stdID int foreign key references Student(stdID)  ,
 Cid int foreign key references Course(Cid) ,
 stdName varchar(35),
 stdDOB Date,
 Cname varchar(30),
 Enrolldate Date,
 primary key (stdID,Cid))

 select * from Student
 select * from Course
 select * from Enrollment
 