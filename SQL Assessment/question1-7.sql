SELECT * FROM transaction_details
SELECT * FROM loan_details
SELECT * FROM account_master
SELECT * FROM customer_master
SELECT * FROM branch_master

-------------------------------------------------------1stques----------------------------------------------------

select a.account_number,a.customer_number,c.first_name,c.last_name,a.account_opening_date from
account_master a left join
customer_master c
on a.customer_number=c.customer_number


--------------------------------------------------------2ndques----------------------------------------------------

select count(customer_city) as 'Cust_Count' from customer_master where customer_city='DELHI'


----------------------------------------------------------3rdques---------------------------------------------------

select a.account_number,a.customer_number,c.first_name from
account_master a left join
customer_master c
on a.customer_number=c.customer_number where day(a.account_opening_date)>15


-----------------------------------------------------------4thques-------------------------------------------------------

select c.customer_number, c.first_name, a.account_number from
customer_master c
left join
account_master a
on a.customer_number=c.customer_number where a.account_status='TERMINATED' order by c.customer_number asc, a.account_number asc

-----------------------------------------------5th ques-------------------------------------------------------------------

select count(*) as Trans_Count , t.transaction_type
from transaction_details t, account_master a
where a.account_number = t.account_number and a.customer_number like '%001' group by t.transaction_type order by t.transaction_type asc;


----------------------------------------------6thques----------------------------------------------------------


select  count(*) as Count_Customer from customer_master 
where customer_number not in (select distinct customer_number from account_master)


-----------------------------------------------7thques----------------------------------------------------------

select t.account_number,sum(transaction_amount)+opening_balance as"Deposit_Amount" from transaction_details t
join account_master a on a.account_number=t.account_number
where transaction_type = 'DEPOSIT'
group by t.account_number, a.opening_balance
