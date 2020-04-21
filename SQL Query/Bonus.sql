use CitiZone
go
create proc Finddaydd 
@Date datetime
as
begin
 select 'name'=b.Foodname ,'ts'=sum(a.Amount) from BILLINFO a ,FOOD b ,BILL c where a.FoodID=b.FoodID and a.BillID=c.BillID and c.BillDate=@Date  group by b.Foodname
end
go
exec Finddaydd '2019-04-1'
