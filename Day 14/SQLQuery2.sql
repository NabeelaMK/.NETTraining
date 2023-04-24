create table Persons(
PersonID int,
LastName varchar(255),
FirstName varchar(255),
Address varchar(255),
City varchar(255)
);
insert into Persons values(101,'M K','Nabeela','Mannil Kadavan','Manjeri');
insert into Persons values
(102,'M K','Nusriya','Mannil Kadavan','Manjeri'),
(103,'P','Souda','Puthalan','Malappuram'),
(104,'Ashraf','Mohammed','Mannil Kadavan','Anakkottupuram');
select * from Persons;

select FirstName from Persons where firstname like 'N%';

delete from Persons where Personid=1;

alter table persons
add Age int;


