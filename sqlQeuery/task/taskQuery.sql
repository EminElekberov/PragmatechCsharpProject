--create database Academy
--use Academy
create table Student(
id int identity(1,1),
Grade int,
Fullanme nvarchar(50),
Birthdate date,
Groups int
)
--insert example 
insert into dbo.Student(Fullanme,Grade,Birthdate,Groups)
values('Emin Elekberov',11,'1985-12-13',2000),
('Rehim Abbasov',11,'1985-10-15',1600),
('Rasim Eliyev',10,'1985-12-13',300),
('Eli veliyev',11,'1985-09-17',789),
('Cavad Azizbeyli',8,'1985-03-14',152),
('Elsen Qedirli',11,'1985-05-28',180)

--And operator example
select * from dbo.Student where id=5

--Or operator example
select * from dbo.Student where Fullanme='Eli veliyev' or Birthdate='1985-05-28'

--In operator example
select * from dbo.Student where id in(5,8)

--beetwen operator example
select * from dbo.Student where id between 5 and 10

--Like operator example
select * from dbo.Student where Fullanme like '%Eliyev'

--fetch operator example
select * from dbo.Student order by id offset 3 rows fetch next 4 rows only

--offset operator example
select * from dbo.Student order by id offset 3 rows

--delete example 
delete from dbo.Student where id=11 and Fullanme='Rasim Eliyev'

--update example 
update dbo.Student set Fullanme='Emin' where id=1


--other examples
select * from dbo.Student order by Groups Desc

select * from dbo.Student order by Groups Asc

select * from dbo.Student where Grade=(select MIN(Grade) from dbo.Student)

select SUM(Groups) from dbo.Student

select top(8)* from dbo.Student



SELECT Grade AS secilen_sinif
FROM dbo.Student where id=13

--islemir
--SELECT Min(Groups)
--FROM dbo.Student
--WHERE condition;
--SELECT MIN(Grade) AS SmallestPrice
--FROM dbo.Student;

--sullar 
--any all exists group by bunlar iki able arasindamim islenir?