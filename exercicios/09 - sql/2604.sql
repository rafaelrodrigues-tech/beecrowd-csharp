create table products(
	id numeric primary key,
	name varchar(225),
	amount integer,
	price decimal(10,2)
);

insert into products(id,name,amount,price)
values (1,'Two-door wardrobe',100,80);

insert into products(id,name,amount,price)
values (2,'Dining table',1000,560);

insert into products(id,name,amount,price)
values (3,'Towel holder',10000,5.50);

insert into products(id,name,amount,price)
values (4,'Computer desk',350,100);

insert into products(id,name,amount,price)
values (5,'Chair',3000,210.64);

insert into products(id,name,amount,price)
values (6,'	Single bed',750,99);

select * from products;

select id,name from products where price < 10 or price > 100;