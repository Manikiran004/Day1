create table emp(id int,name varchar(20));
insert into emp values(1,'mkr');
select * from emp
insert into emp values(2,'reddy');
insert into emp values(3,'kiran');
insert into emp values(4,'ram');
delete emp where id in (1,3);
delete emp;

delete from emp where id=3;
update emp set name='ramraj' where id=1