
--INSERT TRIGGER--

/*create trigger empid on employee
after insert
as
select 'Row Created'

insert into employee(empid, empname, age, salary)
values(1001,'Manu',30,50000)*/

--DELETE TRIGGER--

/*create trigger emptrig on employee
after delete
as
select 'Row Deleted'

delete from employee where empid=1001*/

--UPDATE TRIGGER--

create trigger emptrigger on employee
after update
as
select 'Row Updated'

update employee set empid=1005 where empid=106;




