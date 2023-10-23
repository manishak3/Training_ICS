create database Code_Test
use Code_Test

create table Code_Employee(
empno int Identity(1,1) primary key,
empname Varchar(35) not null,
empsal Numeric(10, 2) Check (empsal >= 25000),
emptype char(1) Check (emptype in ('F', 'P'))
)
set identity_insert Code_Employee on

create or alter proc addemployee
@empname varchar(35),
@empsal numeric(10, 2),
@emptype char(1)
as
begin
declare @NewEmpNo int
select @NewEmpNo = isnull(max(empno), 0) + 1 from Code_Employee

insert into Code_Employee(empno, empname, empsal, emptype)values
(@NewEmpNo, @empname, @empsal, @emptype)
set identity_insert Code_Employee off
select @NewEmpNo as NewEmployeeNo
end
execute AddEmployee @empname = 'Manisha', @empsal =35000, @emptype = 'F'


declare @empno numeric(4);

declare @sal int;
declare employee_cursors CURSOR FOR

select empno, sal

from emp

where deptno = 10;
open employee_cursors;
FETCH NEXT from employee_cursors into @empno, @sal;
while @@FETCH_STATUS = 0

begin
 update emp

    set sal= sal * 1.15

    where empno = @empno;
 FETCH NEXT from employee_cursors into @empno, @sal;

end
CLOSE employee_cursors;

DEALLOCATE employee_cursors;
SELECT * FROM Emp WHERE deptno = 10;
