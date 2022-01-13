--create table Employee(

--id int identity(100,1),
--Firstname nvarchar(25),
--Email nvarchar(50),
--Birthdate date,
--Salary decimal
--)
--insert emeliyyati 
insert into dbo.Employee(Firstname,Email,Birthdate,Salary)
values
('Emin','emin09@gmail.com', '1900-02-20',2500),
('Sahin','sahin@gmail.com', '1800-02-20',2000),
('Rasim','rasim98@gmail.com', '1900-02-20',2500),
('Eli','Eli@gmail.com', '1800-02-20',2000)

select * from dbo.Employee
--select emeliiyati
select Firstname,Email,Birthdate From dbo.Employee Where Firstname='Emin'

select Firstname,Email,Birthdate From dbo.Employee

select * from dbo.Employee where Email like '%gmail.ru'

select * from dbo.Employee where id between 100 and 118

select Email from dbo.Employee where Email like 'Mina%'

select * from dbo.Employee where  not Salary=1800

select top(2) * from dbo.Employee

select * from dbo.Employee order by id offset 3 rows

SELECT * FROM dbo.Employee ORDER BY Salary DESC 

--delete emeliyyati
delete from dbo.Employee where Firstname='Emin'


delete from dbo.Employee where id=112

delete from dbo.Employee where id between 107 and 110

delete  dbo.Employee where id in(113,114)

--update emeliyyati 
update dbo.Employee set Firstname='Eminnn' where id=118
Alter table dbo.Employee add  City nvarchar(50) 