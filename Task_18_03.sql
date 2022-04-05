create database product;
use product;

create table products(id int primary key identity, product_name varchar(20) not null, product_type varchar(20) not null, product_q int not null);


insert into products(product_name, product_type, product_q) values('onions', 'vegitables', 100);
insert into products(product_name, product_type, product_q) values('Apple', 'Fruit', 50);
insert into products(product_name, product_type, product_q) values('Cucumber', 'vegitables', 120);
insert into products(product_name, product_type, product_q) values('Banana', 'vegitables', 110);

select * from products;
alter table products add product_sell int;
alter table products add week1 int;
alter table products add week2 int;
alter table products add week3 int;
alter table products add week4 int;
alter table products add price money;
alter table products add avgsell int;
update products set price=100 where id=1;
update products set price=200 where id=2;
update products set price=300 where id=3;
update products set price=400 where id=4;
update products set price=500 where id=6;

delete from products where id=8;

alter table products drop column product_sell;




select AVG(product_q) from products;


create table EDI(ISA varchar(50) not null, GS varchar(50) not null, ST varchar(50) not null, BIG varchar(50) not null, N1 varchar(50) not null, N2 varchar(50) not null, N3 varchar(50) not null, N4 varchar(50) not null);

Drop table EDI;
select * from EDI;
create table EDI(id int primary key identity, ISA varchar(1000), GS varchar(1000) , ST varchar(1000), BIG varchar(1000), N1 varchar(1000), N2 varchar(1000), N3 varchar(1000), N4 varchar(1000));
