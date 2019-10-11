create database assessment

create table branch_master(
branch_id varchar(6),
branch_name varchar(30),
branch_city varchar(30),
constraint pk_bid primary key(branch_id),
)


create table loan_details(
customer_number varchar(6),
branch_id varchar(6),
loan_amount int,
constraint fk_bid foreign key(branch_id) references branch_master (branch_id),
constraint fk_cust foreign key(customer_number) references customer_master (customer_number),
)


create table customer_master(
customer_number varchar(6),
first_name varchar(30),
middle_name varchar(30),
last_name varchar(30),
customer_city varchar(15),
customer_contact_no varchar(10),
occupation varchar(20),
customer_date_of_birth Date,
constraint pk_cusno primary key(customer_number)
)


create table transaction_details(
transaction_number varchar(6),
account_number varchar(6),
date_of_transaction Date,
medium_of_transaction varchar(20),
transaction_type varchar(20),
transaction_amount int,
constraint pk_tran primary key(transaction_number),
constraint fk_acc foreign key( account_number ) references account_master ( account_number ),
)



create table account_master(
account_number varchar(6),
customer_number varchar(6),
branch_id varchar(6),
opening_balance int,
account_opening_date Date,
accoount_type varchar(10),
account_status varchar(10),
constraint pk_acc primary key(account_number),
constraint fk_cus foreign key(customer_number) references customer_master (customer_number),
constraint fk_bid1 foreign key(branch_id) references branch_master (branch_id),
)
