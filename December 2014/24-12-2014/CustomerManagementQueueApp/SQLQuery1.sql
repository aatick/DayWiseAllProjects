drop table t_Customer_Complain
create table t_Customer_Complain
(
	Id int not null primary key identity(1,1),
	customer_name varchar(50) not null,
	customer_complain varchar(50) not null,
	customer_status varchar(50) not null
)