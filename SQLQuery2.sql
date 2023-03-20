use master 
drop database if exists Rstring
go
create database Rstring
go
use Rstring
go
create table customer
(
Id varchar(100) primary key,
Name varchar(100),
Number int,
Transectiondate datetime,
Photo image,
stringphoto varchar(100),
)
go
create  table bankaccount(
accountid varchar(100),
slno int,
bankname varchar(100),
amount money,
customerid varchar(100) references customer(id),
primary key(accountid,slno)
)
select * from customer
select * from bankaccount