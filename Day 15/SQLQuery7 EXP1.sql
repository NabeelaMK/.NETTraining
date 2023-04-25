select * from countries;
select * from departments;
select * from employees;
select * from job_history;
select * from jobs;
select * from locations;
select * from regions;

--Q4--

select first_name, last_name, salary, 12*salary+100 as 'monthly salary plus a monthly bonus of $100, multiplied by
12' from employees;

--Q5--

alter table employees alter column phone_number numeric(7,0);
UPDATE EMPLOYEES SET phone_number = CONCAT('2', phone_number); 

--Q6--

DELETE employee_id, salary, job_id FROM employees WHERE dept_id = 502;

/* ANS: When using the DELETE statement to delete data from a table, we should only specify the table name
and the WHERE clause that identifies the rows to be deleted. You should not include the column names in the DELETE statement.
The correct syntax would be: DELETE FROM employees WHERE dept_id = 90; */

--Q7--

SELECT COUNT(DISTINCT department_id)
FROM employees
WHERE last_name = 'Smith';

--Q8--

SELECT first_name, last_name, hire_date HIREDATE, salary
FROM EMPLOYEES
ORDER BY hire_date;

--Q9--

create table student_grades(
student_id NUMERIC(12),
semester_end date,
gpa NUMERIC(4,3));
INSERT INTO student_grades VALUES
(1001,'02-10-2022',6.6),
(1002,'02-10-2022',9.8),
(1003,'02-10-2022',5.4),
(1004,'02-10-2022',8.5);
SELECT * FROM student_grades;
SELECT STUDENT_ID, GPA
FROM STUDENT_GRADES
ORDER BY GPA DESC;

--Q10--

SELECT first_name, last_name, job_id, salary
FROM employees
LEFT OUTER JOIN departments
ON employees.department_id = departments.department_id
WHERE departments.department_id IS NULL;

--Q11--

create table customers(
customer_id numeric(4) not null,
customer_name varchar(100) not null,
customer_address varchar(150),
customer_phone varchar(20));
insert into customers values
(2001,'Mr.Bean','Loveshore',5671905437),
(2002,'Nobita','Shuan Street',8734183901),
(2003,'Shin Chan','Xing Street',7615307452);
select * from customers;
select 'Dear customer ' + customer_name + ', ' from customers;

--Q12--

CREATE TABLE emp (
 id INT,
 name VARCHAR(50),
 sal DECIMAL(10,2),
 comm_pct DECIMAL(3,2),
 pf DECIMAL(10,2),
 hra DECIMAL(10,2),
 tearn DECIMAL(10,2),
 tded DECIMAL(10,2),
 net DECIMAL(10,2)
);

INSERT INTO emp (id, name, sal, comm_pct) VALUES
(1, 'Tom Cruise', 200000, 0.08),
(2, 'John Wick', 30000, 0.65),
(3, 'Jerry', 15000, 0.08);

select * from emp;
UPDATE emp
SET pf = sal * 0.1,
  hra = sal * 0.12,
  tearn = sal + (sal * 0.12),
  tded = (sal * 0.1) + (sal * 0.04),
  net = sal + (sal * 0.12) - ((sal * 0.1) + (sal * 0.04));













































