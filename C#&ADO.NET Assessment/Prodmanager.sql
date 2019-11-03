create database ProductSelectionManager

create table ProductTable
(
product_id int,
product_name varchar(40),
constraint pk_pid primary key(product_id),
)

create table CustomerTable
(
customer_id int primary key identity,
customer_name varchar(40),
product_id int,
no_ofproducts int,
supplier_id int,
total_bill_amount float,
constraint fk_pid foreign key( product_id ) references ProductTable ( product_id ),
constraint fk_sid foreign key( supplier_id ) references SupplierTable ( supplier_id ),
)

create table SupplierTable
(
supplier_id int,
supplier_name varchar(40),
product_id int,
location varchar(40),
product_price bigint,
constraint pk_sid primary key(supplier_id),
constraint fk_pid1 foreign key( product_id ) references ProductTable ( product_id ),
)

select * from CustomerTable
select * from ProductTable
select * from SupplierTable

drop table CustomerTable