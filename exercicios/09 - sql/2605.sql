create table products(
	id numeric primary key,
	name varchar(225),
	amount integer,
	price decimal(10,2),
	id_providers numeric ,
	id_categories numeric ,

	constraint fk_prd_id_providers foreign key(id_providers) references providers (id_providers),
	constraint fk_prd_id_categories foreign key(id_categories) references categories(id_categories)
);

insert into products(id,name,amount,price,id_providers,id_categories)
values(1,'Two-door wardrobe',100,800,6,8);

insert into products(id,name,amount,price,id_providers,id_categories)
values(2,'Dining table',1000,560,1,9);

insert into products(id,name,amount,price,id_providers,id_categories)
values(3,'Towel holder',10000,25.50,5,1);

insert into products(id,name,amount,price,id_providers,id_categories)
values(4,'Computer desk',350,320.50,4,6);

insert into products(id,name,amount,price,id_providers,id_categories)
values(5,'Chair',3000,210.64,3,6);

insert into products(id,name,amount,price,id_providers,id_categories)
values(6,'Single bed',750,460,1,2);

select * from products;


create table providers(
	id_providers numeric primary key,
	name varchar(225),
	street varchar(225),
	city varchar(225),
	state char(2)
);

insert into providers(id_providers,name,street,city,state)
values(1,'Henrique','Av Brasil','Rio de Janeiro','RJ');

insert into providers(id_providers,name,street,city,state)
values(2,'Marcelo Augusto','Rua Imigrantes','Belo Horizonte','MG');

insert into providers(id_providers,name,street,city,state)
values(3,'Caroline Silva','Av São Paulo','Salvador','BA');

insert into providers(id_providers,name,street,city,state)
values(4,'Guilerme Staff','Rua Central','Porto Alegre','RS');

insert into providers(id_providers,name,street,city,state)
values(5,'Isabela Moraes','Av Juiz Grande','Curitiba','PR');

insert into providers(id_providers,name,street,city,state)
values(6,'Francisco Accerr','Av Paulista','São Paulo','SP');

select * from providers;


create table categories(
	id_categories numeric primary key,
	name varchar(225)
);

insert into categories(id_categories, name) values(1,'old stock');
insert into categories(id_categories, name) values(2,'new stock');
insert into categories(id_categories, name) values(3,'modern');
insert into categories(id_categories, name) values(4,'commercial');
insert into categories(id_categories, name) values(5,'recyclable');
insert into categories(id_categories, name) values(6,'executive');
insert into categories(id_categories, name) values(7,'superior');
insert into categories(id_categories, name) values(8,'wood');
insert into categories(id_categories, name) values(9,'super luxury');
insert into categories(id_categories, name) values(10,'vintage');

select * from categories;


-- Problema: retornar nomes dos produtos e dos fornecedores cujo codigo da categoria é 6

select 
	products.name,
	providers.name
from products
join providers
	on products.id_providers = providers.id_providers
where products.id_categories = 6;





