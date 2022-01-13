use Csharp03
create table Groups(
Id int primary key identity,
[Name] nvarchar (50) not null  unique
)
drop table Groups

create table Students(
Id int primary key identity,
Firstname nvarchar(30) not null check(len(Firstname)>2),
Email nvarchar(50) not null unique ,--bir mail ile ikinci sefer qeydiyyat etmeye icaze vermememk ucun isdidfade edilir
Gender nvarchar(6) check(Gender in('male','female')),
Country nvarchar(200) Default 'Azerbaijan'
)
drop table Students
alter table Students add GroupId int
alter table Students add Grade int

select SUM(Grade) from Students where Grade>20
--database haqda melumat
execute sp_helpdb Csharp03

--3 cur relation var 
--One to one   : yeni bi rmuellifin bir kitabi ola biler
create table Author(
Id int primary key identity,
[Name] nvarchar(50)
)

create table Book(
Id int primary key identity,
[Name] nvarchar(50),
AuthorId int unique not null, --bunun ona gore yazdiqki cunki her muelifin bir kitabi ola biler oina gorede book tablesinde author tabllesinin id saxlayiriq
Foreign key (AuthorId) references Author(Id)-- menasi odurki burdaki AuthorId columunu borlesdiririk Author tablesinin idsine
)


--One to many   :bir muellifin bir cox kitabi ola biler
create table Author1(
Id int primary key identity,
[Name] nvarchar(50) 
)

create table Book1(
Id int primary key identity,
[Name] nvarchar(50),
AuthorId int  not null, --bunun ona gore yazdiqki cunki her muelifin bir nece kitabi ola biler oina gorede book tablesinde author tabllesinin id saxlayiriq
Foreign key (AuthorId) references Author(Id)-- menasi odurki burdaki AuthorId columunu borlesdiririk Author tablesinin idsine
)

--Many to many   :bir kitabinda cox muellifi ola biler bir muellifinde cox kitabi ola biler
create table Author2(
Id int primary key identity,
[Name] nvarchar(50) 

)
create table Book2(
Id int primary key identity,
[Name] nvarchar(50) 
)
create table Author2ToBook2(
AuthorId int  not null,
Foreign key (AuthorId) references Author2(Id),
BookId int  not null,
Foreign key (BookId) references Book2(Id)
)
select * from Author2ToBook2
Join Author2 on Author2ToBook2.AuthorId=Author2.Id
Join Book2 on Author2ToBook2.BookId=Book2.Id

select Author2.Name,Book2.Name
from Author2ToBook2
Join Author2 on Author2ToBook2.AuthorId=Author2.Id
Join Book2 on Author2ToBook2.BookId=Book2.Id


select * from Author2ToBook2
Join Author2 as a  on Author2ToBook2.AuthorId=a.Id
Join Book2 as b on Author2ToBook2.BookId=b.Id


create table Groups2(
Id int primary key identity,
[Name] nvarchar (50) not null  unique
)

create table Students2(
Id int primary key identity,
Firstname nvarchar(30) not null check(len(Firstname)>2),
Email nvarchar(50) not null unique ,
Gender nvarchar(6) check(Gender in('male','female')),
Country nvarchar(200) Default 'Azerbaijan',
GroupId int not null,
Foreign key (GroupId) references Groups2(Id)
)

select Students2.Firstname 'Telebe', Groups2.Name 'Group'  from Students2
Left join Groups2 on Students2.GroupId=Groups2.Id

select Students2.Firstname 'Telebe',Students2.Email, Groups2.Name 'Group'  from Students2
Left join Groups2 on Students2.GroupId=Groups2.Id

select *  from Students2
Left join Groups2 on Students2.GroupId=Groups2.Id