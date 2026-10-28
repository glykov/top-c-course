create database auto_lot;

use auto_lot;

create table inventory
(
	car_id int auto_increment primary key,
	make_id int not null,
	color varchar(50),
	pet_name varchar (10),
	time_stamp timestamp
);

create table makes
(
	make_id int auto_increment primary key,
	name varchar(50) not null,
	time_stamp timestamp
);

create table customers
(
	customer_id int auto_increment primary key,
	first_name varchar(50) not null,
	last_name varchar(50) not null,
	time_stamp timestamp
);

create table orders
(
	order_id int auto_increment primary key,
	customer_id int not null,
	car_id int not null,
	time_stamp timestamp
);

create table credit_risks
(
	id int auto_increment primary key,
	first_name varchar(50) not null,
	last_name varchar(50) not null,
	customer_id int not null,
	time_stamp timestamp
);

alter table inventory add constraint fk_make_inventory foreign key (make_id) references makes(make_id);

alter table orders add constraint fk_orders_inventory foreign key (car_id) references inventory(car_id);

alter table orders add constraint uq_orders_customer_car unique (customer_id, car_id);

alter table orders add constraint fk_orders_customers foreign key (customer_id) references customers(customer_id) on delete cascade ;

alter table credit_risks add constraint fk_credit_risk_customer foreign key (customer_id) references customers(customer_id) on delete cascade;

-- delimiter $$
-- create procedure get_pet_name(
-- 	in p_car_id int,
-- 	out p_pet_name varchar(10)
-- )
-- begin
-- 	select pet_name into p_pet_name from inventory where car_id = p_car_id;
-- end $$
-- delimiter ;

insert into makes(make_id, name) values
(1, 'VW'), (2, 'Ford'), (3, 'Saab'), (4, 'Yugo'), (5, 'BMW'), (6, 'Pinto');

insert into inventory(car_id, make_id, color, pet_name) values
(1, 1, 'Black', 'Zippy'),
(2, 2, 'Rust', 'Rusty'),
(3, 3, 'Black', 'Mel'),
(4, 4, 'Yellow', 'Clunker'),
(5, 5, 'Black', 'Bimmer'),
(6, 5, 'Green', 'Hank'),
(7, 5, 'Pink', 'Pinky'),
(8, 6, 'Black', 'Pete'),
(9, 4, 'Brown', 'Brownie');

insert into customers(customer_id, first_name, last_name) values 
(1, 'Dave', 'Brenner'), (2, 'Matt', 'Walton'), (3, 'Steve', 'Hagen'),
(4, 'Pat', 'Walton'), (5, 'Bad', 'Customer');

insert into orders(order_id, customer_id, car_id) values 
(1, 1, 5), (2, 2, 1), (3, 3, 4), (4, 4, 7);

insert into credit_risks(id, first_name, last_name, customer_id) values 
(1, 'Bad', 'Customer', 5);













































