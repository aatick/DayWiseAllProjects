create database UniversityDB
use UniversityDB
create table tbl_department
(
id int not null primary key identity(1,1),
name varchar(50) not null
)
create table tbl_employee
(
id int not null primary key identity(1,1),
first_name varchar(50) not null,
employee_address varchar(50) not null,
phone_Nnumber varchar(13) not null,
department_id int not null foreign key references tbl_department(id),
IsConfirmed bit not null default '0'
)
insert into tbl_department values('Administration')
insert into tbl_department values('Human Resource Development')
insert into tbl_department values('Account')
insert into tbl_department values('Management')
