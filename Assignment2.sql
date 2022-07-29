-- Database

USE AdventureWorks2019
GO

-- q1

SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c INNER JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode

-- q2

SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name in ('Germany', 'Canada')

-- Database

USE Northwind
GO

-- q3

SELECT p.ProductName, COUNT(p.ProductName) as NumbOfOrders
FROM Products p JOIN [Order Details] od on p.ProductID = od.ProductID JOIN Orders o on o.OrderID = od.OrderID
GROUP BY p.ProductName
HAVING COUNT(p.ProductName) >= 1

-- q4

SELECT TOP 5 p.ProductName, COUNT(p.ProductName) as NumbOfOrders
FROM Products p JOIN [Order Details] od on p.ProductID = od.ProductID JOIN Orders o on o.OrderID = od.OrderID
GROUP BY p.ProductName
HAVING COUNT(p.ProductName) >= 1
ORDER BY NumbOfOrders DESC

-- q5

SELECT City, count(City) as NumbOfCustomers
FROM Customers
GROUP BY City

-- q6

SELECT City, count(City) as NumbOfCustomers
FROM Customers
GROUP BY City
HAVING count(City) > 2

-- q7

SELECT c.ContactName, COUNT(od.Quantity) TotalNumOfProducts
FROM Customers c JOIN Orders o ON c.CustomerID = O.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.ContactName
ORDER BY TotalNumOfProducts DESC

-- q8

SELECT c.CustomerID, COUNT(od.Quantity) TotalNumOfProducts
FROM Customers c JOIN Orders o ON c.CustomerID = O.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.CustomerID
HAVING COUNT(od.Quantity) > 100
ORDER BY TotalNumOfProducts DESC

-- q9

SELECT su.CompanyName AS 'Supplier Company Name', sh.CompanyName AS 'Shipping Company Name'
FROM Suppliers su CROSS JOIN Shippers sh

-- q10

SELECT o.OrderDate, p.ProductName
FROM Products p JOIN [Order Details] od on p.ProductID = od.ProductID JOIN Orders o on o.OrderID = od.OrderID
ORDER BY OrderDate

-- q11

SELECT e.LastName as 'Employee 1', ee.LastName as 'Employee 2', e.Title
FROM Employees e JOIN Employees ee on e.Title = ee.Title
WHERE e.EmployeeID <> ee.EmployeeID 

-- q12

SELECT e.EmployeeID
FROM Employees e
WHERE e.EmployeeID IN (
    SELECT EmployeeID, count(ReportsTo)
    FROM Employees
    GROUP BY EmployeeID)

-- q13

SELECT dt.City as City, dt.CompanyName as 'Company Name', dt.ContactName as 'Contact Name'
FROM (SELECT c.CustomerID, s.SupplierID, c.City, c.CompanyName, c.ContactName
FROM Customers c JOIN Suppliers s ON c.City = s.City ) dt

-- q14

SELECT DISTINCT e.City
FROM Employees e JOIN Customers c ON e.City = c.City

-- q15

SELECT DISTINCT c.City
FROM Customers c
WHERE c.City NOT IN (
    SELECT DISTINCT e.City
    FROM Employees e 
) 

SELECT DISTINCT c.City
FROM Employees e RIGHT JOIN Customers c ON e.City = c.City
WHERE e.City IS NULL

-- q16

SELECT p.ProductName, SUM(o.Quantity) TotalNumOfProducts
FROM Products p JOIN [Order Details] o ON p.ProductID = o.ProductID 
GROUP BY p.ProductName
ORDER BY TotalNumOfProducts DESC

-- q17

SELECT c.City
FROM Customers c
GROUP BY c.City
HAVING count(c.City) >= 2

-- q18 

SELECT s.ShipCity 
FROM Orders s
GROUP BY SHipCity
HAVING COUNT(ShipCity) >= 2

-- q21
-- By using DISTINCT or UNION