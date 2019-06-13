CREATE TABLE Products
(
ID INT IDENTITY(1,1),
Name VARCHAR(50),
CategoryId int not null,
Price int
)

CREATE TABLE Categories (
ID INT IDENTITY,
Name VARCHAR(50)
)

insert into Categories values ('Fashion')
insert into Categories values ('Electronics')
insert into Categories values ('Mobile')
insert into Categories values ('Computer')

select *from Categories


INSERT INTO Products VALUES('SHIRT',1,101)
INSERT INTO Products VALUES('Washing Machine',2,2000)
INSERT INTO Products VALUES('Pant',1,5000)
INSERT INTO Products VALUES('Fan',2,1600)
INSERT INTO Products VALUES('Samsung s8',3,25000)
INSERT INTO Products VALUES('Asus Zenfone',3,2500)
INSERT INTO Products VALUES('Samsung Ram 8gb',4,8000)
INSERT INTO Products VALUES('Asus 21" monitor',4,8589633)

SELECT *FROM Categories
SELECT *FROM Products

SELECT p.Name, c.Name   FROM Products as p
join Categories as c
on p.CategoryId = c.ID
--where CategoryId = 2


select MAX(Price) from Products

select *from Products
select Name,Price  from Products
where Price = (select MAX(price) from Products)

SELECT p.Name, c.Name as [Category Name],p.Price   FROM Products as p
join Categories as c
on p.CategoryId = c.ID
where Price = (select MAX(price) from Products)
