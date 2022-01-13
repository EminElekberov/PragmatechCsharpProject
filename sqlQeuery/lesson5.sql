create database vidoe24

--yanlis kodlar
--create table Employee(
--Id int primary key identity,
--[Name] nvarchar(20),
--Emp_salary decimal(10,2)
--)

--create table HrContact(
--EmpId int,
--[Name] nvarchar(20),
--Emp_salary decimal(10,2),
--Addadate datetime 
--)


--create trigger trgafterinsertEmployee on 
--[HrContact]
--for insert 
--as
--declare @empId int;
--declare @emp_name nvarchar(20);
--declare @empadd datetime;
--declare @empSalary decimal(10,2);
--select @empId=y.EmpId from inserted y
--select @emp_name=y.EmpId from inserted y
--select @empId=y.EmpId from inserted y
--select @empSalary=y.Emp_salary from inserted y
--insert into HrContact(EmpId,[Name],Emp_salary,Addadate)
--values (@empId,@emp_name,@empadd,@empSalary)

--print 'after insert trigger'
--go


create table Employee(
Id int identity,
[Name] nvarchar(20),
Emp_Salary decimal(10,2)
)

create table HrContactData(
EmpID int,
[Name] nvarchar(20),
Emp_Salary decimal(10,2),
AddedDate datetime
)


create trigger trgAfterInsertEmployee on
dbo.[Employee]
for insert
as
declare @empID int;
declare @emp_name nvarchar(20);
declare @empSalary decimal(10,2);
declare @addedDate datetime;
select  @empID=y.Id from inserted y
select  @emp_name=y.[Name] from inserted y
select  @empSalary=y.Emp_Salary from inserted y 

insert into HrContactData(EmpID,[Name],Emp_Salary,AddedDate)
values (@empID,@emp_name,@empSalary, getdate())

Print 'After Insert trigger '
go
insert into Employee values('vygbhujbjn',1500)