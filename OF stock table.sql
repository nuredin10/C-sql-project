create database [Stock Managment]
use [Stock Managment]
drop database [Stock Managment]

create table tblCatagory
(id int  primary key identity ,
 catagory nvarchar(500),
  sub_catagory nvarchar(500)
)

create table tblItem
( id int  primary key identity ,
 itemCode nvarchar(255)  ,
  itemDescription nvarchar(500) not null,
  quantity float,
  UOM nvarchar(255),
  unitPrice float,
  brandName varchar(50),
  catagoryid int
)

create table tblTranction 
(
id int primary key identity,
purchased float,
sells float,
invoiceNumber int,
[date] date,
itemid int,
supplierID int
)


create table tblSupplier
(
[tinNumber] int primary key, ---only 10 digit number 
supplierName nvarchar(500),
[date] date
)

create table tbluser
(
id int identity, 
name nvarchar(500),
username nvarchar(500),
[password] nvarchar(500)
)
------
---constraint 
alter table tblitem 
add constraint fk_catagory
foreign key (catagoryid) references tblcatagory(id)

alter table tbltranction 
add constraint fk_tranItem
foreign key (itemid) references tblitem(id)

alter table tbltranction 
add constraint fk_tranSupplier
foreign key (supplierid) references tblSupplier(tinnumber)


alter table tbltranction 
add suppierid int not null




alter table tblSupplier
drop constraint fk_purtran
foreign key (tranctionid) references tblTranction (id)

alter table tbltranction 
add 
alter table tblSupplier
drop column 
alter table tblSupplier 
drop constraint PK__tblSuppl__8A2D8A53BF160111


alter table tblSupplier
add  tranctionid int

----made a mistake when i make the foreign key in supploer , it should be in trancion 
