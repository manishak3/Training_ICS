use Assignment2

CREATE TABLE Code_Employee (
   empno int primary key,
   empname varchar(35) not null,
   empsal numeric(10,2) check (empsal >= 25000),
   emptype char(1) check (emptype in ('F', 'P'))
);
 
 
CREATE or alter PROCEDURE  AddEmployee
   @empname varchar(45),
   @empsal numeric(10,3),
   @emptype char(1)
AS
BEGIN
   DECLARE @empno int;
 
   SELECT @empno = ISNULL(MAX(empno), 0) + 1 FROM Code_Employee;
 
   INSERT INTO Code_Employee (empno, empname, empsal, emptype)
   VALUES (@empno, @empname, @empsal, @emptype);
END;

-- Declare the variables for the cursor
DECLARE @empnum NUMERIC(4);
DECLARE @salary INT;

-- Declare the cursor
DECLARE employee_cursors CURSOR FOR
SELECT empno, sal
FROM emp
WHERE deptno = 10;

-- Open the cursor
OPEN employee_cursors;

-- Fetch the first row
FETCH NEXT FROM employee_cursors INTO @empnum, @salary;

-- Loop through the cursor
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Update the salary with a 15% increase
    UPDATE emp
    SET sal= sal * 1.15
    WHERE empno = @empnum;
-- Fetch the next row
    FETCH NEXT FROM employee_cursors INTO @empnum, @salary;
END

-- Close and deallocate the cursor
CLOSE employee_cursors;
DEALLOCATE employee_cursors;

--Select the updated value for verification
SELECT * FROM Emp WHERE deptno = 10;

 

 