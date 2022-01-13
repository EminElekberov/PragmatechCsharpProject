create database Market 
create table Products (
Id int primary key identity,
[Name] nvarchar(30) not null ,
Price int  
)
alter table dbo.Products add  Brand nvarchar(50)
alter table dbo.Products drop column Brand

insert into dbo.Products([Name],Price,Brand)
values
('paltar',15,'Zara'),
('Ayyaqqabi',20,'Adidas'),
('Sarf',16,'Nike'),
('Mebel',23,'Embawood'),
('M5F10',50,'Bmw'),
('E63',40,'MRC'),
('M3F80',49,'Bmw'),
('M4f82',80,'Bmw'),
('G63',79,'Mrc'),
('F90',156,'BMW')

select * from dbo.Products where Price>10

select Price 'ortalama'  from dbo.Products where Price>(SELECT avg(Price) FROM dbo.Products)


select * from dbo.Products 
SELECT Brand  FROM dbo.Products WHERE Brand>(SELECT len(Brand)>5 FROM dbo.Products)