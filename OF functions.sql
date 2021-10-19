------
---item total price

create function calculateTotal(@quantity float,@unitprice float)
returns float
as
begin
declare @totalprice float = 0.0 
set @totalprice = @quantity * @unitprice
return @totalprice
end

go
CREATE function calculateAvagerSalary(@Newunitprice float,@newquantity float,@id int)
returns float
as
begin
declare @avgsalary float,@oldprice float,@oldQuantity float,@totalprice float , @totalquantity float

select  @oldprice =unitPrice, @oldQuantity= quantity  from tblitem where id =@id

set @totalprice = (@oldprice*@oldQuantity )+ (@Newunitprice *@newquantity)
set @totalquantity = @newQuantity +@oldQuantity 
set @avgsalary  =  @totalprice/@totalquantity
return  @avgsalary
end
go


go
create function udfTotalStock(@id int)
returns float
as 
begin
declare @totalstock float
select @totalstock = quantity from tblItem where id = @id
return @totalstock
end
-----i use dthis code whne my sql mananger wont open 
/*go
sp_configure 'show advanced options', 1;
RECONFIGURE;
GO
sp_configure 'Ad Hoc Distributed Queries', 1;
RECONFIGURE;
GO

EXEC master.dbo.sp_MSset_oledb_prop N'Microsoft.Jet.OLEDB.4.0', N'DynamicParameters', 1
EXEC sp_MSset_oledb_prop N'Microsoft.ACE.OLEDB.12.0', N'DynamicParameters', 1
go
insert into OPENROWSET('Microsoft.ACE.OLEDB.12.0',
    'Excel 12.0; Database=C:\Documents\copy of testing.xlsx','select itemcode,DISCRIPTION ,uom,qty,U.PRICE/VAT  from [Sheet1$]')
GO
*/

select * from tblSupplier

select * from tblitem
select dbo.calculateAvagerSalary(9000,15,7)
select dbo.udfTotalStock(2)
exec uspinsertTranction 20,0,09090909,'2021-10-14','3709','TRIMMER',91233,'ASF rading plc',4000
select * from tblTranction
select *from tblSupplier
delete from tblItem
delete from tblTranction