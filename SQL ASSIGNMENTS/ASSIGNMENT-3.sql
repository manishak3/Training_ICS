use Assignment2

select * from EMP
select * from DEPT

--Retrieve a list of MANAGERS
select * from EMP where job = 'MANAGER'

--Find out the names and salaries of all employees earning more than 1000 per month
select ename,sal from EMP where sal > 1000

--Display the names and salaries of all employees except JAMES
select ename,sal from EMP where ename != 'james'

--Find out the details of employees whose names begin with ‘S’
select * from EMP where ename like 'S%'

--Find out the names of all employees that have ‘A’ anywhere in their name
select ename from EMP where ename like '%A%'

--Find out the names of all employees that have ‘L’ as their third character in their name
select ename from EMP where ename like '__L%' 

--Compute daily salary of JONES
select ename,sal/31 as DailySal from EMP where ename = 'JONES' 

--Calculate the total monthly salary of all employees
select sum(sal) as Total_Salary from EMP  

--Print the average annual salary
select avg(sal*12) as Average_Annual_Salary from EMP

--Select the name, job, salary, department number of all employees except SALESMAN from department number 30
select ename,job,sal,deptno from EMP where deptno=30 and job<>'SALESMAN'

--List unique departments of the EMP table. 
select distinct dname from EMP join DEPT 
on EMP.deptno = DEPT.deptno

--List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename, sal from emp where sal>1500 and deptno in (10,30)

-- Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000
select ename,job,sal from EMP where job in ('MANAGER','ANALYST') and sal not in (1000,3000,5000)

-- Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10% 
select ename,sal,comm from EMP where comm > (sal * 0.1)

--Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782
select ename from EMP where ename like'%LL%'  and deptno=30 or mgr_id=7782

-- Display the names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees.
 select ename from EMP
 where DATEDIFF (year,hiredate,GETDATE())>=30 and DATEDIFF (year,hiredate,GETDATE()) < 40
 select count(*) as 'count'from EMP
 where DATEDIFF (year,hiredate,GETDATE())>=30 and DATEDIFF (year,hiredate,GETDATE()) < 40

 -- Retrieve the names of departments in ascending order and their employees in descending order
 select d.dname,e.ename from DEPT d,EMP E
 where e.deptno = d.deptno
 order by d.deptno asc,e.empno desc

 --Find out experience of MILLER
 select DATEDIFF (year,hiredate,GETDATE()) as experience from EMP
 where ename = 'MILLER'
