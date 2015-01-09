create database EmployeeDB
use EmployeeDB
create table tbl_designation
(
id int not null primary key identity(1,1),
code varchar(30) not null ,
title varchar(50) not null
)
create table tbl_employee
(
serial int not null primary key identity(1,1),
name varchar(50) not null,
email varchar(50) not null,
address varchar(100) not null,
designationId int not null foreign key references tbl_designation(id)
)
