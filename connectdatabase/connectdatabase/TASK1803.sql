create database employee;
use employee;

SELECT sobjects.name
FROM sysobjects sobjects
WHERE sobjects.xtype = 'U'

create table newjoinee(id int primary key identity, flname varchar(50) not null);
create table exesting(id int primary key identity, flname varchar(50) not null);


insert into newjoinee(flname) values ('james');
select * from newjoinee;

insert into newjoinee(flname) values ('peter');
insert into newjoinee(flname) values ('roy');
insert into newjoinee(flname) values ('abc');
insert into newjoinee(flname) values ('cde');
insert into newjoinee(flname) values ('ccc');
insert into newjoinee(flname) values ('eee');



insert into exesting(flname) values ('aaa');
insert into exesting(flname) values ('bbb');
insert into exesting(flname) values ('ccc');
insert into exesting(flname) values ('eee');
insert into exesting(flname) values ('fff');

select newjoinee.id, newjoinee.flname, exesting.flname from newjoinee inner join exesting on newjoinee.flname = exesting.flname;
select newjoinee.id, newjoinee.flname, exesting.flname from newjoinee left join exesting on newjoinee.flname = exesting.flname;
select newjoinee.id, newjoinee.flname, exesting.flname from newjoinee right join exesting on newjoinee.flname = exesting.flname;
select newjoinee.id, newjoinee.flname, exesting.flname from newjoinee full join exesting on newjoinee.flname = exesting.flname;


create table nt(val int not null);
insert into nt(val) values (100);
insert into nt(val) values (10);
insert into nt(val) values (50);
insert into nt(val) values (111);
insert into nt(val) values (120);


select val  from nt;

select AVG(ALl val) from nt;
select MIN(val) from nt;
select MAX(val) from nt;
select COUNT(*) from nt;



