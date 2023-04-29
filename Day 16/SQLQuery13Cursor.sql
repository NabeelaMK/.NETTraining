
/*--Local variable--
declare @salary money

--Define the cursor--
declare SalCur cursor
for
select salary from employee order by salary;

--Open cursor (retrieve data)--
open SalCur;

--Perform the first fetch (get first row)--
fetch next from SalCur into @salary

--Close cursor--
close SalCur

--And finally remove it--
deallocate SalCur;*/


--FETCH THE LOOP--

DECLARE @employee_id INT
DECLARE @Salary DECIMAL(10, 2)
DECLARE @Grandsalary DECIMAL(10, 2) = 0
DECLARE employee_cursor CURSOR FOR

SELECT empid, salary
FROM Employee
OPEN employee_cursor
FETCH NEXT FROM employee_cursor INTO @employee_id, @Salary
WHILE @@FETCH_STATUS = 0
BEGIN
  SET @Grandsalary = @Grandsalary + @Salary
  FETCH NEXT FROM employee_cursor INTO @employee_id, @Salary
  SELECT @employee_id AS empid, @Salary AS salary
END
CLOSE employee_cursor
DEALLOCATE employee_cursor

SELECT @Grandsalary AS GrandSalary




