select * from sys.Tables
use Billing

select * from BillDetail

select * from InvoiceDetails

drop table BillDetails

alter table  Billdetail add Total int 

update BillDetail set PrintStatus ='Y' where ProductId= 101 