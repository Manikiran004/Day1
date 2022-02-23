use mkr;
create table employee(eid int,name varchar(20),salary int)
insert into employee values(1,'raj',15000)
insert into employee  values(2,'ram',10000)
insert into employee values(3,'ravi',19000)
insert into employee values(4,'hari',20000)
select * from employee

select Max(salary) as secondmaxsalary from employee where salary< (select Max(salary) from employee)
drop table employee
