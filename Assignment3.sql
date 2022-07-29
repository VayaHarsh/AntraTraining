-- q1

CREATE VIEW view_product_order_vaya
AS
SELECT ProductID, Quantity FROM [Order Details]

SELECT * FROM view_product_order_vaya

-- q2

CREATE PROC sp_product_order_quantity_vaya @ProdID int
AS
BEGIN
    SELECT QuantityPerUnit FROM Products WHERE @ProdID = ProductID 
END

EXEC sp_product_order_quantity_vaya 5

-- q3

CREATE PROC sp_product_order_city_vaya @ProductName nvarchar(40)
AS
BEGIN
    SELECT TOP 5 o.ShipCity, SUM(od.Quantity) as Quant
    FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID 
    WHERE @ProductName = p.ProductName
    GROUP BY o.ShipCity
    ORDER BY Quant DESC
END

-- q4

CREATE TABLE people_vaya
(
    Id INT,
    Name NVARCHAR(30),
    City int
)

CREATE TABLE city_vaya
(
    Id INT,
    City NVARCHAR(30)
)

INSERT INTO people_vaya VALUES
(1, 'Aaron Rodgers', 2), 
(2, 'Russell Wilson', 1), 
(3, 'Jody Nelson', 2)

INSERT INTO city_vaya VALUES
(1, 'Seattle'), (2, 'Green Bay')

DELETE FROM city_vaya WHERE City = 'Seattle'

INSERT INTO city_vaya VALUES
(1, 'Madison')

CREATE VIEW Packers_vaya AS
SELECT p.Name FROM people_vaya p 
WHERE p.City = 2

DROP TABLE people_vaya
DROP TABLE city_vaya
DROP VIEW Packers_vaya

-- q5

CREATE PROC sp_birthday_employees_vaya AS
BEGIN
    CREATE TABLE birthday_employees_vaya (EmpId int)
END

DROP PROC sp_birthday_employees_vaya

-- q6

-- Check distinct count(*) for both tables. Must be equal.
-- Union of both tables. The count should be equal to the count found above.
