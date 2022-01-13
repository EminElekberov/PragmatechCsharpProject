create database COMPANY 

use COMPANY 

create table CUSTOMERS(
Id int primary key identity,
[Name] nvarchar(30) not null ,
Surname nvarchar(30) not null,
Salary int  
)


insert into dbo.CUSTOMERS([Name],Surname,Salary)
values
('Emin','Elekberov',30),
('Rehim','Rehimli',59),
('Rasim','Eliyev',60)

select * from CUSTOMERS

update dbo.CUSTOMERS set [Name]='Elsad' where Id=3 

delete from dbo.CUSTOMERS where Id=6

select avg(Salary) 'ortalama'  from CUSTOMERS

select avg(Salary)  'ortalama' from dbo.CUSTOMERS where Salary>47



SELECT [Name],Salary FROM dbo.CUSTOMERS WHERE Salary=(SELECT MIN(Salary) FROM dbo.CUSTOMERS)

SELECT Surname FROM dbo.CUSTOMERS WHERE Salary=(SELECT MIN(Salary) FROM dbo.CUSTOMERS)



alter table dbo.CUSTOMERS  add POSITIONID int

create table Position(
Id int primary key identity,
[Name] nvarchar(30) not null
)


create table CustomersToPosition(
CUSTOMERSid int  not null,
Foreign key (CUSTOMERSid) references CUSTOMERS(Id),
PositionId int  not null,
Foreign key (PositionId) references Position(Id)
)


select * from CustomersToPosition
Join CUSTOMERS as c  on CustomersToPosition.CUSTOMERSid=c.Id
Join Position as p on CustomersToPosition.PositionId=p.Id