create database CitiZone
use CitiZone

	create table accounts
		(
			username nvarchar(20) not null, 
			password nvarchar(20) not null,
			fullname nvarchar(50),
			birthday date,
			address nvarchar(50),
			phone int,
			position nvarchar(20) not null,
			pictureLocation nvarchar(200),
			constraint pk_accounts primary key(username)
		)

	insert into accounts(username, password, position)
	values ('admin', '123', 'admin')
	

	create table categories
		(
			categoryID nvarchar(50),
			categoryName nvarchar(50)
			constraint pk_categories primary key(categoryID)
		)

	create table foods
		(
			foodID int identity primary key,
			foodName nvarchar(50),
			price int,
			categoryID nvarchar(50),
			constraint fk_foods_categories foreign key(categoryID)
			references categories(categoryID)
		)
		
	create table bills
			(
				billID int identity primary key,
				username nvarchar(20),
				billName nvarchar(50),
				billDate datetime,
				total int,
				constraint fk_bill_accounts foreign key(username)
				references accounts(username)
			)

	create table billInfo
		(	foodID int,
			billID int,
			amount int,
			total int,
			constraint fk_billinfo_foods foreign key(foodID)
			references foods(foodID),
			constraint fk_billInfo_bills foreign key(billID)
			references bills(billID),
			constraint pk_billInfo primary key(foodID,billID)
		)
go



	create procedure addAccounts
		@username nvarchar(20),
		@password nvarchar(20),
		@position nvarchar(20)
	as
	begin
		insert into accounts(username, password, position)
		values (@username, @password, @position)
	end
	go

	create procedure deleteAccounts
		@username varchar(20)
	as 
	begin
		delete from accounts
		where username = @username
	end 
	go

	create procedure updateAccounts
		@username nvarchar(20),
		@password nvarchar(20),
		@position nvarchar(20)
	as
	begin
		update accounts
		set password = @password,
		position = @position
		where username = @username
	end
	go

	create procedure updateInfoAccounts
		@username nvarchar(20),
		@password nvarchar(20),
		@fullname nvarchar(50),
		@birthday date,
		@address nvarchar(50),
		@phone int,
		@pictureLocation nvarchar(200)
	as
	begin 
		update accounts
		set password = @password,
		fullname = @fullname,
		birthday = @birthday,
		address = @address,
		phone = @phone,
		pictureLocation = @pictureLocation
		where username = @username
	end
	go

	create procedure addCategories
		@categoryID nvarchar(50),
		@categoryName nvarchar (50)
	as
	begin
		insert into categories(categoryID, categoryName)
		values (@categoryID, @categoryName)
	end
	go

	create procedure updateCategories
		@categoryID nvarchar(50),
		@categoryName nvarchar (50)
	as
	begin 
		update categories
		set categoryName = @categoryName
		where categoryID = @categoryID
	end
	go

	create procedure deleteCategories
		@categoryID nvarchar(50)
	as
	begin
		delete from categories
		where categoryID = @categoryID
	end
	go

	create procedure addFoods
		@foodname nvarchar(50),
		@price int,
		@categoryID nvarchar(50)
	as
	begin
		insert into foods(foodname, price, categoryID)
		values (@foodname, @price, @categoryID)
	end
	go

	create procedure updateFoods
		@foodID int,
		@foodname nvarchar(50),
		@price int
		as
		begin 
	update foods
	set foodname = @foodname,
	price= @price
	where foodID = @foodID
	end
	go

	create procedure deleteFoods
		@foodID int
	as
	begin 
		delete from foods
		where foodID = @foodID
	end
	go

	create procedure deleteFoodsByCategories
		@categoryID nvarchar(50)
	as 
	begin 
		delete from foods
		where categoryID = @categoryID
	end	
	go

	create procedure addBills
		@username nvarchar(20),
		@billName nvarchar(50),
		@billDate datetime
	as
	begin
		insert into bills(username, billName, billDate)
		values(@username, @billName,@billDate)
	end
	go

	create procedure updateBills
		@billID int,
		@total int
	as
	begin
		update bills
		set total = @total
		where billID = @billID
	end
	go
		
	create procedure deleteBills
		@billID int
	as
	begin
		delete from  bills
		where billID = @billID
	end
	go

	create procedure deleteBillsByUsername
		@username nvarchar(20)
	as
	begin
		delete from bills
		where username = @username
	end
	go

	create procedure addBillInfo
		@foodID int,
		@billID int,
		@amount int,
		@total int
	as begin
		insert into billInfo(foodID, billID, amount, total)
		values (@foodID, @billID, @amount, @total)
	end
	go

	create procedure deleteBillInfo
		@billID int
	as
	begin
		delete from billInfo
		where billID = @billID
	end
	go

	create table coffeeTable
	(
		tableID int,
		billID int,
		status nvarchar(10),
		constraint pk_coffeeTable primary key(tableID),
		constraint fk_coffeeTable_bills foreign key(BillID)
		references bills(billID)
	)
	go
	insert into coffeeTable(tableID, billID, status)
	values(0, null, 'empty')
	insert into coffeeTable(tableID, billID, status)
	values(1, null, 'empty')
	insert into coffeeTable(tableID, billID, status)
	values(2, null, 'empty')
	insert into coffeeTable(tableID, billID, status)
	values(3, null, 'empty')
	insert into coffeeTable(tableID, billID, status)
	values(4, null, 'empty')
	insert into coffeeTable(tableID, billID, status)
	values(5, null, 'empty')
	insert into coffeeTable(tableID, billID, status)
	values(6, null, 'empty')
	insert into coffeeTable(tableID, billID, status)
	values(7, null, 'empty')
	insert into coffeeTable(tableID, billID, status)
	values(8, null, 'empty')
	insert into coffeeTable(tableID, billID, status)
	values(9, null, 'empty')
	go
	create procedure updateCoffeeTable
		@tableID int,
		@billID int,
		@status nvarchar(10)
	as
	begin
		update coffeeTable
		set billID = @billID,
			status = @status
		where tableID = @tableID
	end
	go

	create procedure searchBills
		@billID int,
		@billName nvarchar(50)
	as
	begin
		select * from bills
		where billID = @billID  OR billName LIKE '%'+@billName+'%'
	end
	go

	create procedure SearchBillinfosByBillID 
		@billID int
	as
	begin
		select f.foodName,binfo.amount,f.price from billInfo binfo inner join foods f on binfo.foodID = f.foodID  
		where binfo.billID=@billID 
	end
	go
	exec SearchBillinfosByBillID '2'