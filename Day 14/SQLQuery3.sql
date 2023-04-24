select GetDate();

select 10+10

create table employee(empid int primary key,empname varchar(50),age int, salary money);
insert into employee values
(101,'Athira',24,25000),
(102,'Aleena',23,26323),
(103,'Nabeela',24,21000),
(104,'Dhanya',22,17897);
select * from employee;
select count(empid) as Count ,salary from employee group by salary;