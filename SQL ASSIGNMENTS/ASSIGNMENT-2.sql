create database Assignment2
use Assignment2

create table EMP(
empno int primary key,
ename varchar(15),
job varchar(20),
mgr_id int,
hiredate Date,
sal int,
comm int,
deptno int
)

create table DEPT(
deptno int primary key,
dname varchar(10),
loc varchar(30)
)

insert into EMP values
(7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81 ',1600,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30),
(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10),
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20),
(7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20),
(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10)

select * from EMP

insert into DEPT values
(10,'ACCOUNTING','NEW YORK'), 
(20,'RESEARCH','DALLAS'), 
(30,'SALES','CHICAGO'),
(40,'OPERATIONS','BOSTON')

select * from DEPT

--List of employees whose name starts with'A'
select * from EMP where ename Like 'A%'

--Select all those employees who don't have a manager 
select * from EMP where job Like '[^m]%'

--List employee name, number and salary for those employees who earn in the range 1200 to 1400
select ename,empno,sal from EMP where sal between 1200 and 1400

-- Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise 
select * from Emp where deptno=20  
select Ename, sal, (sal*1.10) as Rise_in_Sal 
from EMP where deptno=20

--Find the number of CLERKS employed. Give it a descriptive heading. 
select count(job)  as 'Number of Clerks employed' from EMP  where job='clerk'

--Find the average salary for each job type and the number of people employed in each job. 
select job, Avg(sal) as Avg_salary ,Count(job) as NO_of_People from EMP Group by job

--List the employees with the lowest and highest salary. 
select * from EMP where sal=(select max(sal) from EMP) or sal=( select min(sal) from EMP)

--List full details of departments that don't have any employees. 
select * from DEPT  where deptno not in (select deptno from EMP)

--Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select ename ,sal
from EMP 
where job='analyst' and sal>1200 and deptno=20
order by ename desc

--For each department, list its name and number together with the total salary paid to employees in that department 
select * from DEPT
select dname,sum (sal) as Total_sal 
from DEPT join emp on DEPT.deptno=emp.deptno group by dname 

--Find out salary of both MILLER and SMITH
select ename,sal  from EMP where ename in ('miller','smith')

--Find out the names of the employees whose name begin with ‘A’ or ‘M’ 
select ename from EMP where ename like '[AM]%'

--Compute yearly salary of SMITH 
select ename ,(sal*12) 'Yearly_salary' from EMP where ename='smith'

--List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select ename ,sal from EMP where sal  not between 1500 and 2850

--Find all managers who have more than 2 employees reporting to them
Select e.mgr_id as Manager_id, m.ename as Manager_name, COUNT(*) AS employee_count
from EMP e
JOIN EMP m ON e.mgr_id = m.empno
group by e.mgr_id, m.ename
Having count(*) > 2