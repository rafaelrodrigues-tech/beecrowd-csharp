create table customers
(
	id numeric primary key,
	name varchar(255),
	street varchar(255),
	city varchar(255),
	state char(2),
	credit_limit decimal(10,2)
);

select * from customers;

insert into customers (id,name,street,city,state,credit_limit)
values (1,'Pedro Augusto da Rocha', 'Rua Pedro Carlos Hoffman','Porto Alegre','RS','700.00');

insert into customers (id,name,street,city,state,credit_limit)
values (2,'Antonio Carlos Mamel','Av. Pinheiros','Belo Horizonte','MG',3500.50);

insert into customers (id,name,street,city,state,credit_limit)
values (3,'Luiza Augusta Mhor','Rua Salto Grande','Niteroi','RJ',4000.00);

insert into customers (id,name,street,city,state,credit_limit)
values (4,'Jane Ester','Av 7 de setembro','Erechim','RS',800.00);

insert into customers (id,name,street,city,state,credit_limit)
values (5,'Marcos Antônio dos Santos','Av Farrapos','Porto Alegre','RS',4250.25)

select name from customers where state = 'RS'; -- Problema Select Básico 2602

select name,street from customers where city = 'Porto Alegre'; -- Problema Endereço dos clientes 2603
