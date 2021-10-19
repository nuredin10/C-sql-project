/*
 catagory 
*/

create proc uspInsertCatogory---powertools , spare parts and acc are makita
@catagory nvarchar(500),
@subcatagory nvarchar(500)
as 
begin
declare @id int
 insert into tblcatagory values (@catagory,@subcatagory)
 set @id = scope_identity()
 return @id
end

go
create  proc uspUpdateCatogory---powertools , spare parts and acc are makita
@catid int,
@catagory nvarchar(500),
@subcatagory nvarchar(500)
as 
begin
update tblcatagory set catagory = @catagory ,sub_catagory = @subcatagory
where id = @catid
end
go
------------
---item
---
------------

-----update,insert and search and view
alter proc uspInsertItem---if the catagory already exist then let it just add teh existing primary key else insert  new calagory 
@ItemCode varchar(500),
@itemDescription nvarchar(500),
@quantity float,
@catagory nvarchar(500),
@subcatagory nvarchar(500),
@UOM nvarchar(50),
@unitPrice float,
@brandName varchar(50) = 'Makita'
as
begin
  declare @catid int
if not exists (select id from tblCatagory where catagory = @catagory and sub_catagory = @subcatagory)
 exec @catid = uspInsertCatogory @catagory,@subcatagory
else 
  begin
  select @catid = id from tblCatagory where catagory = @catagory and sub_catagory = @subcatagory
  end
insert into tblItem  values (@ItemCode,@itemDescription,@quantity,@UOM ,@unitPrice,@brandName,@catid)
end



go
alter proc uspUpdateItem
@id int,
@ItemCode nvarchar(500),
@itemDescription nvarchar(500),
@quantity float,
@catagory nvarchar(500),
@subcatagory nvarchar(500),
@UOM nvarchar(50),
@unitPrice float,
@brandName varchar(50) = 'Makita'
as
begin
declare @catid int
select @catid = catagoryid from tblItem where id = @id
if(@catid is null)
begin
 if not exists (select id from tblCatagory where catagory =@catagory and sub_catagory =@subcatagory  )
 begin 
    exec @catid=uspInsertCatogory @catagory,@subcatagory
 end
 else 
  select @catid = id from tblCatagory where catagory =@catagory and sub_catagory =@subcatagory
end
else
exec uspUpdateCatogory @catid,@catagory,@subcatagory
update tblItem set  itemcode = @ItemCode , itemdescription = @itemdescription,quantity = @quantity ,uom = @uom,unitPrice=@unitPrice,  brandName = @brandName,catagoryid = @catid
where id = @id
end

go
alter proc uspDeleteItem
@id int
as
begin
delete from tblTranction where itemid = @id
delete from tblitem---can not only delete this because ut is a reference
where id = @id
end
go


alter proc uspSearchItemByItemCode
@val nvarchar(500)
as
begin
select i.id ,c.catagory+' '+sub_Catagory as [Catagory], itemcode as [Item Code],itemdescription as [Item Describtion],quantity as[Quantity] ,uom,unitPrice  as [Unit price],dbo.calculateTotal(quantity,unitPrice) as [Total price], brandName as [Brand Name]
from tblItem i
join tblcatagory c
on  catagoryid = c.id
where i.itemcode like '%'+@val+'%'
order by c.catagory +' '+c.sub_catagory 
end

go
alter proc uspSearchItemByItemCodeAndDescribtion
@val nvarchar(500)
--@catagory nvarchar(400) output 
as
begin

select i.id , itemcode as [Item Code],itemdescription as [Item Describtion],quantity as[Quantity],c.catagory ,sub_Catagory ,uom,unitPrice  as [Unit price],dbo.calculateTotal(quantity,unitPrice) as [Total price], brandName as [Brand Name]
from tblItem i
left outer join tblcatagory c
on  catagoryid = c.id
where ltrim(rtrim(i.itemDescription)) like '%'+@val+'%' or ltrim(rtrim(i.itemcode)) like '%'+@val+'%'
order by c.catagory +' '+c.sub_catagory 
end

delete from tblitem where id = null
go
alter proc uspSearchItemByCatagory
@val nvarchar(500)
as
begin
declare @catagory nvarchar(500) ,@subcat nvarchar(500)
select @catagory = catagory , @subcat = sub_catagory   from tblCatagory where catagory like @val+'%'
select i.id , itemcode as [Item Code],itemdescription as [Item Describtion],quantity as[Quantity],c.catagory ,sub_Catagory ,uom,unitPrice  as [Unit price],dbo.calculateTotal(quantity,unitPrice) as [Total price], brandName as [Brand Name]
from tblItem i
 join tblcatagory c
on  catagoryid = c.id
where c.catagory like '%'+@val+'%'
order by c.catagory +' '+c.sub_catagory 
end
go

alter proc uspViewItem
as
begin
select i.id , itemcode as [Item Code],itemdescription as [Item Describtion],quantity as[Quantity],c.catagory ,sub_Catagory ,uom,unitPrice  as [Unit price],dbo.calculateTotal(quantity,unitPrice) as [Total price], brandName as [Brand Name]
from tblItem i
left outer join tblcatagory c
on  catagoryid = c.id
order by c.catagory +' '+c.sub_catagory 
end

/*-
supplier 
*/
select * from tblitem
go
create proc uspInsertSupplier
@tinumber int,
@suppliername nvarchar(500),
@date date
as
begin
insert into tblSupplier values (@tinumber,@suppliername,@date)
end
go 

alter proc uspupdateSupplier
@tinumber int,
@suppliername nvarchar(500),
@date date
as
begin
update tblSupplier set supplierName =@suppliername  ,date = @date
where tinnumber = @tinumber
end
go

alter proc uspSearchSupplierByname
@suppliername nvarchar(500)
as
begin
select tinNumber , suppliername as [Supplier Name],datename(month,date) as [Month],date as [Date] from tblSupplier
where suppliername like '%'+@suppliername +'%'
end
go

create proc uspSearchSupplierByTinnumber
@tinumber int
as
begin
select tinNumber , suppliername as [Supplier Name],datename(month,date) as [Month],date as [Date] from tblSupplier
where tinnumber = @tinumber 
end
go

create proc uspViewSupplier
as
begin
select tinNumber , suppliername as [Supplier Name],datename(month,date) as [Month],date as [Date] from tblSupplier
end
go


create proc uspDeleteSupplier
@tinnumber int
as
begin
delete from tblSupplier where tinNumber = @tinnumber
end

-----
---tracntion 
--- --- add if needed
go

----

alter proc uspinsertTranction
@purchase float,
@sells  float,
@invoicenumber int,
@date date,
@itemcode nvarchar(500),
@itemdescribtion nvarchar(500),
@tinNumber int,
@supplierName nvarchar(500),
@uprice float,
@output varchar(100) output
as
begin
declare @tranid int,@itemid int, @temprice money, @quantity float 
select @itemid = id, @temprice = unitPrice, @quantity = quantity  from tblitem where itemcode = @itemcode and itemdescription = @itemdescribtion 
if (@sells != 0)
update tblitem set quantity = quantity - @sells where id = @itemid
else if (@purchase != 0)
begin

if (@uprice != @temprice)
update tblitem set unitPrice = dbo.calculateAvagerSalary(@uprice,@purchase,@itemid) where id = @itemid
set @output = dbo.calculateAvagerSalary(@uprice,@purchase,@itemid)
update tblitem set quantity = quantity + @purchase where id = @itemid
end
if not exists(select tinNumber from tblSupplier where tinNumber = @tinNumber )
     exec uspInsertSupplier @tinNumber , @supplierName, @date

insert into tbltranction values (@purchase,@sells,@invoicenumber,@date,@itemid,@tinNumber)
end
go 

select 
create proc uspupdateTranction
@tranid int,
@purchase float,
@sells  float,
@invoicenumber int,
@date date,
@itemcode nvarchar(500),
@itemdescribtion nvarchar(500),
@tinNumber int,
@supplierName nvarchar(500)
as
begin
declare @itemid int ,@tempsells float, @temppurchase float

select @tempsells = sells, @temppurchase = purchased from tblTranction WHERE  id = @tranid 
select @itemid = id from tblitem where itemcode = @itemcode and itemdescription = @itemdescribtion 
update tbltranction set purchased = @purchase,sells = @sells,invoicenumber= @invoicenumber,date = @date, itemid = @itemid,supplierID = @tinNumber
where id = @tranid
set @tranid = SCOPE_IDENTITY()
if (@sells != @tempsells)
update tblitem set quantity = quantity + @tempsells - @sells
where id = @itemid
else if (@purchase != @temppurchase)
begin
update tblitem set quantity = quantity + @purchase- @temppurchase
where id = @itemid
end
end
go 


create proc uspdeleteTransaction
@tranid int 
as
begin
delete from tblTranction where id = @tranid
end
go

alter proc uspViewTransaction 
as
begin
select t.id,i.itemCode,i.itemDescription,i.quantity as [Balance],i.unitPrice,dbo.calculateTotal(i.quantity,i.unitPrice) as [Total price],c.catagory as [Catagory], c.sub_catagory as [Sub Catagory],
t.purchased,t.sells,t.invoiceNumber,t.date,datename (month,t.date) as [Month]
from tblitem i
join tblcatagory c
on c.id = i.catagoryid
join tbltranction t
on t.itemid = i.id
ORDER BY c.catagory +' '+c.sub_catagory
end
go

alter proc uspSearchTransactionByItemCode
@val nvarchar(500)
as
begin
select t.id,i.itemCode,i.itemDescription,i.quantity as [Balance],i.unitPrice,dbo.calculateTotal(i.quantity,i.unitPrice) as [Total price],c.catagory+' '+c.sub_catagory as [Catagory],
t.purchased,t.sells,t.invoiceNumber,t.date,datename (month,t.date) as [Month]
from tblitem i
join tblcatagory c
on c.id = i.catagoryid
join tbltranction t
on t.itemid = i.id
where ltrim(rtrim(i.itemDescription)) like '%'+@val+'%' or ltrim(rtrim(i.itemcode)) like '%'+@val+'%'
ORDER BY c.catagory +' '+c.sub_catagory
end
go


alter proc uspSearchTransactionByItemDescribtion
@val nvarchar(500)
as
begin
select t.id,i.itemCode,i.itemDescription,i.quantity as [Balance],i.unitPrice,dbo.calculateTotal(i.quantity,i.unitPrice) as [Total price],c.catagory+' '+c.sub_catagory as [Catagory],
t.purchased,t.sells,t.invoiceNumber,t.date,datename (month,t.date) as [Month]
from tblitem i
 join tblcatagory c
on c.id = i.catagoryid
 join tbltranction t
on t.itemid = i.id
where ltrim(rtrim(i.itemDescription)) like '%'+@val+'%' or ltrim(rtrim(i.itemcode)) like '%'+@val+'%'
ORDER BY c.catagory +' '+c.sub_catagory
end
go

create proc uspSearchTransactionByCatagory
@Catagory nvarchar(500)
as
begin
select t.id,i.itemCode,i.itemDescription,i.quantity as [Balance],i.unitPrice,dbo.calculateTotal(i.quantity,i.unitPrice) as [Total price],c.catagory+' '+c.sub_catagory as [Catagory],
t.purchased,t.sells,t.invoiceNumber,t.date,datename (month,t.date) as [Month]
from tblitem i
join tblcatagory c
on c.id = i.catagoryid
join tbltranction t
on t.itemid = i.id
where c.catagory +' '+c.sub_catagory = @Catagory
ORDER BY c.catagory +' '+c.sub_catagory
end

create proc uspSearchTransactionByDateInterval
@dateOne date,
@dateTwo date
as
begin
select t.id,i.itemCode,i.itemDescription,i.quantity as [Balance],i.unitPrice,dbo.calculateTotal(i.quantity,i.unitPrice) as [Total price],c.catagory+' '+c.sub_catagory as [Catagory],
t.purchased,t.sells,t.invoiceNumber,t.date,datename (month,t.date) as [Month]
from tblitem i
join tblcatagory c
on c.id = i.catagoryid
join tbltranction t
on t.itemid = i.id
where t.date between @dateOne  and @dateTwo
ORDER BY c.catagory +' '+c.sub_catagory
end
go

exec uspSearchTransactionByDateInterval '2020-02-02','2020-12-12'
select * from tblTranction
exec uspinsertitem 'MLS100','METE SAW',1,'power tools','','unit',5659.58 
exec uspinsertitem '3709','TRIMMER',9,'power tools','','unit', 3300.51 
exec uspdeleteitem 4

exec uspinsertitem '445050655','SPROCKET NOSE BAR CHAIN SAW DCS6401',2,'Accessories','','unit', 1351.04 

declare @catogory nvarchar(500)
--exec uspSearchItemByItemCode '37',@catogory output
--print @catogory
exec uspSearchItemByItemCodeandDEscribtion 'sp',@catogory output
select  @catogory 

select * from tbltranction
select * from tblSupplier
select * from tblCatagory

select * from tblitem i
join tblcatagory c
on c.id = i.catagoryid
full outer join tbltranction t
on t.itemid = i.id
full outer join tblSupplier s
on s.tinnumber = t.supplierid
go

select * from tblitem i
join tblcatagory c
on c.id = i.catagoryid
join tbltranction t
on t.itemid = i.id
full outer join tblSupplier s
on s.tinnumber = t.supplierid
go

select * from 
exec uspinsertTranction null,1,0912322,'02-02-2020','3709','TRIMMER',null,null

exec uspinsertTranction 10,0,0912322,'12-12-2020','3709','TRIMMER',091233,'ASF rading plc'

exec uspinsertTranction 10,0,097866767,'12-12-2020','9607HB','JIG SAW',1241234,'jhon', 20432.74

exec uspSearchItemByCatagory 'power tools'

exec uspInsertItem '9607HB','JIG SAW', 15 ,' power tools','unit', 11,432.74 ,'Makita'
select * from tblTranction
select * from tblSupplier
SELECT * FROM tblCatagory
SELECT * from tblitem
DELETE FROM TBLCATAGORY WHERE ID = 3 OR ID = 4
UPDATE tblitem SET CATAGORYID = 1

select *from tblitem

