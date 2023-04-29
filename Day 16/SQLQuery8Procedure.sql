create procedure productpricing as
begin
select Avg(prod_price) as priceaverage
from products;
end;

create or alter procedure sp_PrintDate as
begin
select getdate();
end;

exec sp_PrintDate;


create or alter procedure ShowEmpData as
begin
select Avg(salary) as [Average Salary] from employee;
end;

exec ShowEmpData;


create or alter procedure ShowEmpWithId(@empid int) as
begin
select * from employee where EmpId=@empid;
end;

exec ShowEmpWithId 105;


/*Write a procedure to pass employee id and obtain salary of that employee as output type variable*/
create or alter procedure PassSalary
@empid int, @salary money output as
begin
select @salary= salary from employee where EmpId=@empid;
end;


use EmpDB
declare @empid int
declare @salary money
exec PassSalary @empid = 103, @salary = @salary output;
select @salary;


