--create table 
create table Feedback
(
CustomerId int not null Primary key identity(1,1),
Customername nvarchar(200) not null,
Comments nvarchar(100) not null,
Productname nvarchar(100) not null,
Rating int not null,
Createddate datetime2 not null default(getdate())
)
select *from Feedback
drop table Feedback