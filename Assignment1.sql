-- Database

USE AdventureWorks2019
GO

-- q1

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product

-- q2

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice != 0

-- q3

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL

-- q4

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice > 0 AND Color IS NOT NULL 

-- q5

SELECT Name + ' - ' + Color AS NameColor
FROM Production.Product
WHERE Color IS NOT NULL 

-- q6

SELECT 'NAME: ' + Name + ' -- ' + 'COLOR: ' + Color AS NameColor
FROM Production.Product
WHERE Color IS NOT NULL 

-- q7

SELECT ProductID, Name 
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500

-- q8

SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color = 'Black' OR Color = 'Blue'

-- q9

SELECT ProductID, Name 
FROM Production.Product
WHERE Name LIKE 'S%'

-- q10

SELECT Name, ListPrice 
FROM Production.Product
WHERE Name LIKE 'S%' OR  Name LIKE 'A%'
ORDER BY Name

-- q11

SELECT Name
FROM Production.Product
WHERE Name LIKE 'SPO[^K]%'
ORDER BY Name

-- q12

SELECT DISTINCT ProductSubcategoryID, Color
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL AND Color IS NOT NULL 

