create database AcadamyQuiz
create table Groups(
Id int identity primary key ,
[Name] nvarchar(50) unique not null
)
drop table Groups
create table Students(
Id int identity primary key ,
[Name] nvarchar(50),
Surname nvarchar(50),
GroupId int  not null,
Foreign key (GroupId) references Groups(Id)
)
drop table Students
alter table Students add Grade int
insert into dbo.Groups([Name])
values
('p124'),
('p221'),
('p111')

insert into dbo.Students([Name],Surname,GroupId,Grade)
values 
('Ramiz','Qasimov',1,50)


select *from dbo.Students where GroupId=2


SELECT COUNT(GroupId)  'sayi' FROM  Students where GroupId=2



create view StudendsView as
select Students.Name 'Adi',Students.Surname 'Soyad',Students.Grade,Groups.Name 'Qrup' from Students 
Join Groups on Students.GroupId=Groups.Id

select * from StudendsView
drop view StudendsView


create procedure Summ
@grade int
as
select Students.Name 'Adi',Students.Surname 'Soyad',Students.Grade,Groups.Name 'Qrup' from Students 
Join Groups on Students.GroupID=Groups.Id
where Students.Grade>@grade
execute Summ 10


select Groups.Name,Count(GroupId)'Count' from Students
join Groups
on Students.GroupId=Groups.Id
group by Groups.Name

