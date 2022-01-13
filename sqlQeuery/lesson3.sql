select * from Students2Info
--bunun artiq isidiafde etemeyeceyik cunki biz view yaratidqi ne vaxt bu join lazim olsa yaziqi ki  select * from Students2Info
--create view Students2Info as
--select Students2.Firstname ,Students2.Email,Groups2.Name 'groups',City.Name,Country.Name 'olke adi'
--from Students2 
--Join Groups2 on Students2.GroupId=Groups2.Id
--Join City on Students2.CityId=City.Id
--join Country on City.CountryId=Country.Id
create table Country(
Id int primary key identity,
[Name] nvarchar(50)
) 
select * from Students2Info
create table City(
Id int primary key identity,
[Name] nvarchar(50),
CountryId int not null,
Foreign key(CountryId) references Country(Id)
)
alter table Students2 add CityId int Foreign key (CityId) references City(Id) 
alter table Students2 add Grade int

--prposedur yaratmaq

create procedure usp_prcedure @grade int as
select * from Students2 where Grade>=@grade 
execute usp_prcedure 56


create procedure usq_GetProcedure2
@group nvarchar(max)=null,
@city nvarchar(max)=null,
@country nvarchar(max)=null
as
select Students2.Firstname ,Students2.Email,City.Name,Country.Name 'olke adi'
from Students2 
Join Groups2 on Students2.GroupId=Groups2.Id
Join City on Students2.CityId=City.Id
join Country on City.CountryId=Country.Id
where Groups2.Name like '%' +ISNULL(@group,Groups2.Name)+ '%' And 
City.Name like '%' +ISNULL(@city,City.Name)+ '%' And 
Country.Name like '%' +ISNULL(@country,Country.Name)+ '%'

execute usq_GetProcedure2 '789a1' ,'Baki' ,'Azerbaijan'

execute usq_GetProcedure2 '789a1' ,null ,'Aze'

select * from usq_GetProcedure2


create procedure insert_Prodecure 
@firstName nvarchar(max)=null,
@email nvarchar(max)=null,
@gender nvarchar(max)=null,
@country nvarchar(max)=null,
@groupId int,
@cityId int,
@grade int
as
insert into Students2 (Firstname,Email,Gender,Country,GroupId,CityId,Grade)
values(@firstName,@email,@gender,@country,@groupId,@cityId,@grade)
execute insert_Prodecure 'Emin','emin@gmail.com','Azerbaijan',1,2,55
drop procedure insert_Prodecure
execute insert_Prodecure