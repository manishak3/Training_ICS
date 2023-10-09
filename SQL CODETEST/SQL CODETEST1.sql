CREATE DATABASE CODETEST1
USE CODETEST1

create table books(
id int primary key,
title varchar(30),
author varchar(30),
isbn bigint unique,
published_date varchar(30))

insert into books values
(1,'my first SQL book','Mary Parker',981483029127,'2012-02-22 12:08:17'),
(2,'my second SQL book','John Mayer',857300923713,'1972-07-03 09:22:45'),
(3,'my third SQL book','Cary Flint',523120967812,'2015-10-18 14:05:44')

select *from books

--1.  Write a query to fetch the details of the books written by author whose name ends with er.
select author from books where author like '%er'

create table reviews(
id int,
book_id int,
reviewer_name varchar(30),
content varchar(30),
rating int,
published_date varchar(30))

insert into reviews values
(1,1,'John Smith','my first review',4,'2017-12-10 05:50:11'),
(2,2,'John Smith','my second review ',5,'2017-10-13 15:05:12'),
(3,3,'Alice walker','another review',1,'2015-10-18 14:05:44')
select *from reviews

--2.Display the Title ,Author and ReviewerName for all the books from the above table 
 select title,Author ,Reviewer_Name from books join reviews on books.id=reviews.id
 


--3.Display the  reviewer name who reviewed more than one book.
select reviewer_name from reviews group by reviewer_name having COUNT(*) > 1



create table Customerr(
customer_id int ,
cusname varchar(20),
age int,
cusaddress varchar(20),
salary decimal)

insert into Customerr values
(1,'ramesh',32,'ahmedabad',2000.00),
(2,'khilan',25,'delhi',1500.00),
(3,'kaushik',23,'kota',2000.0),
(4,'chaitali',25,'mumbai',6500.00),
(5,'hardik',27,'bhopal',8500.00),
(6,'komal',22,'mp',4500),
(7,'muffy',24,'indore',10000.00)
select *from customerr


--4.Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address
select * from customerr where cusaddress like '%o%'



create table Orders(
Oid int,
Odate varchar(30),
customer_id int,
amount int)

insert into orders values
(102,'2009-10-08 00:00:00',3,3000),
(100,'2009-10-08 00:00:00',3,1500),
(101,'2009-11-20 00:00:00',2,1560),
(103,'2008-5-20 00:00:00',4,2060)
select *from Orders



--5.Write a query to display the   Date,Total no of customer  placed order on same Date 
select odate, count(DISTINCT customer_id) as total_customers from orders group by odate


create table employee(
emp_id int ,
ename varchar(20),
eage int,
eaddress varchar(20),
salary decimal)

insert into employee values
(1,'ramesh',32,'ahmedabad',2000.00),
(2,'khilan',25,'delhi',1500.00),
(3,'kaushik',23,'kota',2000.0),
(4,'chaitali',25,'mumbai',6500.00),
(5,'hardik',27,'bhopal',8500.00),
(6,'komal',22,'mp',null),
(7,'muffy',24,'indore',null)

--6.Display the Names of the Employee in lower case, whose salary is null 
select lower(ename) as 'lowercase name' from employee where salary is null


create table studentdetails(
register_id int,
sname varchar(30),
sage int,
qual varchar(15),
mobno bigint,
mail varchar(30),
loc varchar(20),
gender varchar(20))

insert into  studentdetails values
(2,'sai',22,'B.E',9952836777,'sai@gmail.com','chennai','M'),
(3,'kumar',20,'BSC',7890125648,'kumar@gmail.com','chennai','M'),
(4,'selvi',22,'B.Tech',8904567342,'selvi@gmail.com','chennai','F'),
(5,'nisha',25,'M.E',7834672310,'nisha@gmail.com','chennai','F'),
(6,'saisaran',21,'B.A',7890345678,'saran@gmail.com','chennai','F'),
(7,'tom',23,'BCA',8901234675,'tom@gmail.com','chennai','M')
select *from  studentdetails

--7.Write a sql server query to display the Gender,Total no of male and female from the above relation  
select gender, COUNT(*) AS total_count from studentdetails group by gender