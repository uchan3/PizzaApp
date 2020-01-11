--Store Level
select * from dbo.SizeDefinition; 
select * from dbo.CrustDefinition; 
select * from dbo.ToppingDefinition; 
select * from dbo.PizzaDefinition; 
select * from dbo.LocationList; 
select * from dbo.UserList; 
select * from dbo.PizzaList; 
select * from dbo.OrderList; 
select * from dbo.ToppingList; 

select * from dbo.CrustList; 
select * from dbo.SizeList; 


delete from dbo.CrustDefinition
where CrustDefID between 4 and 6; 

insert into dbo.SizeDefinition("Name")
values ('Small'), 
('Medium'), 
('Large'); 

insert into dbo.CrustDefinition("Name")
values ('New York'),
('Chicago'), 
('California');

insert into dbo.ToppingDefinition("Name")
values ('Sausage'),
('Pepperoni'),
('Ham');

insert into dbo.UserList("FirstName", "LastName")
values ('John', 'Smith'),
('Joseph', 'Cheung');

insert into dbo.LocationList("Street", "City", "State")
values ('1001 S. Center St.', 'Arlington', 'Texas'), 
('901 Randol Mill', 'Arlington', 'Texas'); 

--Issue: PizzaDefinition is referring to Crust, not Crust Definition. 
--Temporary fix: Remove Crust. PizzaDefinition only knows Name and Price. Does not know about Crust;
insert into dbo.PizzaDefinition("Name", "Price")
values ('New York Pizza', '5.00'),
('Chicago Pizza', '6.00'), 
('California Pizza', '5.50'); 
