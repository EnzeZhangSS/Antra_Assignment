--Assignment 1
--Enze Zhang

--1)
SELECT p.ProductID,p.Name,p.Color,p.ListPrice
FROM Production.Product AS p

--2)
SELECT p.ProductID,p.Name,p.Color,p.ListPrice
FROM Production.Product AS p
WHERE p.ListPrice != 0

--3)
SELECT p.ProductID,p.Name,p.Color,p.ListPrice
FROM Production.Product AS p
WHERE p.Color IS NOT NULL

--4)
SELECT p.ProductID,p.Name,p.Color,p.ListPrice
FROM Production.Product AS p
WHERE p.Color IS NOT NULL AND p.ListPrice > 0

--5)
SELECT p.Name + ' ' + p.Color AS [Name&Color]
FROM Production.Product AS p
WHERE p.Color IS NOT NULL

--6)
SELECT 'NAME: ' +p.Name + '  --  COLOR: ' + p.Color AS [Name&Color]
FROM Production.Product AS p
WHERE p.Color IS NOT NULL AND P.Name LIKE '%Crankarm' OR p.Name LIKE 'Chainring%'

--7)
SELECT p.ProductID,p.Name
FROM Production.Product AS p
WHERE p.ProductID BETWEEN 400 AND 500

--8)
SELECT p.ProductID, p.Name, p.Color
FROM Production.Product AS p
WHERE p.Color IN ('black','blue')

--9)
SELECT *
FROM Production.Product AS p
WHERE p.Name LIKE 'S%'

--10)
SELECT p.Name, p.ListPrice
FROM Production.Product AS p
WHERE p.Name LIKE 'A%' OR p.Name LIKE 'S%'
ORDER BY p.Name

--11)
SELECT *
FROM Production.Product AS p
WHERE p.Name LIKE 'SPO[^K]%'
ORDER BY p.Name

--12)
SELECT DISTINCT p.ProductSubcategoryID,p.Color
FROM Production.Product AS p
WHERE p.ProductSubcategoryID IS NOT NULL AND p.Color IS NOT NULL