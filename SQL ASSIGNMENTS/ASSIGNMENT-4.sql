--Write a T-SQL Program to find the factorial of a given number.
declare @num int
set @num=7
 declare @fact bigint
set @fact=1
 while @num>1
begin
 set @fact = @fact*@num
 set @num = @num-1
end
--Execution
select @fact as 'result'

--2. Create a stored procedure to generate multiplication tables up to a given number.
create procedure MultiplicationTbl   
@num int
as
begin        
declare @n int, @multiresult int;     
set @n = 1;    
while @n <= 10     
begin       
set @multiresult = @num * @n;         
print  cast(@num as varchar(30)) + ' * ' + cast(@n as varchar(10)) + ' = '+ cast(@multiresult as varchar(10));         
set @n = @n + 1;     
end
end
--Execution
execute MultiplicationTbl 3

--3. Create a trigger to restrict data manipulation on EMP table during General holidays.
--Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" 

create table Holidays(
holiday_date Date Primary Key,
holiday_name varchar(30)
);

insert into holidays values
('2023-01-01','NewYear'),
('2023-08-15','Independence Day'),
('2023-08-30','Rakhi'),
('2023-10-24','Dussara'),
('2023-10-15','sunday');

Create trigger RestrictDataManipulation
on employee
for INSERT, UPDATE, DELETE 
AS 
begin    
declare @Holiday_name VARCHAR(50), @holiday_date DATE
set @holiday_date = CONVERT(DATE, GETDATE())
select @Holiday_name = Holiday_name     
from Holidays    
where holiday_date = @holiday_date 
If @holiday_name IS NOT NULL     
begin       
ROLLBACK TRANSACTION        
RAISERROR('Due to %s, you cannot manipulate data', 16, 1, @holiday_name)     
end
end 

insert into Employee values(8,'Rehan',9500,24,'Female','operations');
delete from employee where empid=1



