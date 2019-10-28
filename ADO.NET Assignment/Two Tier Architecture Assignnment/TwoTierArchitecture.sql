create database AdoDemos


create table tblEmployee(
Id int primary key Identity,
Name varchar(20),
Gender varchar(6),
Location varchar(30),
Salary bigint
)

select * from tblEmployee

create procedure sp_InsertNewEmployee(@name varchar(20), @gender varchar(6), @location varchar(30), @salary bigint)
as
begin
insert into tblEmployee values(@name,@gender,@location,@salary)
end

exec sp_InsertNewEmployee 'peter','name','Pune',45657




create procedure sp_UpdateEmployee(@id int, @name varchar(20), @gender varchar(6), @location varchar(30), @salary bigint)
as
begin
update tblEmployee set Name=@name,Gender=@gender, Location=@location, Salary=@salary where Id=@id
end

exec sp_UpdateEmployee 1, 'Lalitha','female','Delhi',45657

select * from tblEmployee


create procedure sp_RetrieveAllEmployee
as
begin
select * from tblEmployee
end

exec sp_RetrieveAllEmployee


create procedure sp_RetrieveEmployeeById(@id int)
as
begin
select * from tblEmployee where Id= 5
end

exec sp_RetrieveEmployeeById 3


alter procedure sp_DeleteEmployeeById(@id int)
as
begin
delete from tblEmployee where Id=@id
end

exec sp_DeleteEmployeeById 4
