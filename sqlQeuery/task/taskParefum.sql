
create database Sale
create table Shops(
Id int primary key identity,
[Name] nvarchar(60) ,
Contact nvarchar(60)
)
create table SelectMarca(
Id int primary key identity,
[Name] nvarchar(60) ,
ShopId int not null,
Foreign key (ShopId) references Shops(Id)
)
create table Price(
Id int primary key identity,
Price int
)
create table Gender(
Id int primary key identity,
MaleOrFamale nvarchar(60)check(MaleOrFamale in('male','female'))
)
drop table Gender

create table Bonus(
Id int primary key identity,
BonusParcent int
)
create table Details(
Id int primary key identity,
SelectedMracDetailsId int not null,
Foreign key (SelectedMracDetailsId) references SelectMarca(Id),
Pricedeatils int not null,
Foreign key (Pricedeatils) references Price(Id),
GenderdetailsId int not null,
Foreign key (GenderdetailsId) references Gender(Id),
BonusDetailsId int not null,
Foreign key (BonusDetailsId) references Bonus(Id)
)

create procedure usp_ShopProcedure
@Name nvarchar(max)=null
as 
insert into Shops([Name])
values(@Name)
execute usp_ShopProcedure 'Parfum 4'


create procedure usp_ShopUpdate
@name nvarchar(max)=null
as
update Shops set [Name]=@name where Id=2
execute usp_ShopUpdate 'Pasrfums 2'

create procedure usp_ShopDelete
@name nvarchar(max)=null
as
delete from  Shops where [Name]=@name


create view DetailsInfo as
select Details.SelectedMracDetailsId,Details.BonusDetailsId,Details.GenderdetailsId,Details.Pricedeatils from Details
join Price on Details.Pricedeatils=Price.Id
join Bonus on Details.BonusDetailsId=Bonus.Id
join SelectMarca on Details.SelectedMracDetailsId=SelectMarca.Id
join Gender on Details.GenderdetailsId=Gender.Id
select * from DetailsInfo

create procedure usp_beetween 
@price int
as 
select * from Price where Price between 10 and 59
execute usp_beetween 56

create procedure usp_beetween @price int as
select * from Price where Price>=@price 

create procedure usp_details
@Price int,
@selectmarc nvarchar(max)=null,
@bonus int
as
select Price.Price,SelectMarca.Name,Bonus.BonusParcent from Details
join Price on Details.Pricedeatils=Price.Id
join Bonus on Details.BonusDetailsId=Bonus.Id
join SelectMarca on Details.SelectedMracDetailsId=SelectMarca.Id
where Price.Price +MAX(@Price,