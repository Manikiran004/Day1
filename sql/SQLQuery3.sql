use mkr
create table sales(id int,name varchar(20),salary int);
insert into sales values(1,'man',2000);
insert into sales values(2,'ram',5000);
insert into sales values(3,'hari',6000);
create procedure p1(in temp int)
begin
update sales set salary=salary+temp;
end
