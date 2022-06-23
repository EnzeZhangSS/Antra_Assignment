--Assignment 2
--Enze Zhang

USE AdventureWorks2019
GO
--1)
SELECT  cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion cr JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode

--2)
SELECT  cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion cr JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode
WHERE cr.Name IN ('Germany','Canada')

USE Northwind
GO
--3)
SELECT DISTINCT p.ProductName
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID
WHERE DATEDIFF(year,o.OrderDate,GETDATE()) <=25

--4)
SELECT TOP 5 o.ShipPostalCode AS [Zip Code], COUNT(o.ShipPostalCode) AS [Sold Count]
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID
WHERE DATEDIFF(year,o.OrderDate,GETDATE()) <=25
GROUP BY o.ShipPostalCode
ORDER BY [Sold Count] DESC

--5)
SELECT City, COUNT(CustomerID) AS NumOfCustomers
FROM Customers
GROUP BY City

--6)
SELECT City, COUNT(CustomerID) AS NumOfCustomers
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) > 2
ORDER BY NumOfCustomers DESC

--7)
SELECT c.CompanyName, SUM(od.Quantity) AS Cnt
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CompanyName

--8)
SELECT c.CustomerID, SUM(od.Quantity) AS Cnt
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID
HAVING SUM(od.Quantity) > 100
ORDER BY Cnt DESC

--9)
SELECT sup.CompanyName AS [Supplier Company Name], ship.CompanyName AS [ Shipping Company Name]
FROM Suppliers sup CROSS JOIN Shippers ship 

--10)
SELECT o.OrderDate,	p.ProductName
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID JOIN Products p ON od.ProductID = p.ProductID
ORDER BY o.OrderDate

--11)
SELECT e1.Title, e1.FirstName+' '+e1.LastName AS [Employee 1 Name], e2.FirstName+' '+e2.LastName AS [Employee 2 Name]
FROM Employees e1 JOIN Employees e2 ON e1.Title = e2.Title
WHERE e1.EmployeeID <> e2.EmployeeID
ORDER BY e1.Title

--12)
SELECT t1.EmployeeID AS ManagerID,t1.FirstName+' '+t1.LastName AS [Manager Name], t2.NumOfReporting 
FROM Employees t1 JOIN
(SELECT ReportsTo AS ManagerID, COUNT(EmployeeID) AS NumOfReporting
FROM Employees e
GROUP BY ReportsTo
HAVING COUNT(EmployeeID)>2) t2
ON t1.EmployeeID = t2.ManagerID

--13)
SELECT City,CompanyName as Name, ContactName, 'Customer' Type
FROM Customers
UNION
SELECT City,CompanyName as Name, ContactName, 'Supplier' Type
FROM Suppliers
ORDER BY City

--14)
SELECT DISTINCT c.City
FROM Customers c JOIN Employees e ON c.City = e.City

--15)
--a)
SELECT DISTINCT City
FROM Customers
WHERE City NOT IN
(
SELECT City 
FROM Employees
)


--b)
SELECT DISTINCT c.City
FROM Customers c LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL

--16)
SELECT p.ProductID,p.ProductName, o.[Total Quantity]
FROM Products p JOIN 
(
SELECT od.ProductID, SUM(od.Quantity) AS [Total Quantity]
FROM [Order Details] od
GROUP BY od.ProductID
) o
ON p.ProductID = o.ProductID
ORDER BY p.ProductID

--17)
--a)
SELECT c.City, COUNT(City) AS NumOfCustomers
FROM
(
SELECT c1.City,c1.CustomerID
FROM Customers c1
UNION 
SELECT c2.City,c2.CustomerID
FROM Customers c2
) c
GROUP BY c.City
HAVING COUNT(City)>=2
ORDER BY NumOfCustomers DESC

SELECT DISTINCT c1.City
FROM Customers c1 JOIN Customers c2 ON c1.City = c2.City
WHERE C1.CustomerID!=C2.CustomerID

--b)
SELECT DISTINCT c.City,
(SELECT COUNT(cm.CustomerID)
FROM Customers cm WHERE c.City = cm.City HAVING COUNT(cm.CustomerID)>=2
)AS NumOfCustomers
FROM Customers c
WHERE (SELECT COUNT(cm.CustomerID)
FROM Customers cm WHERE c.City = cm.City HAVING COUNT(cm.CustomerID)>=2
) IS NOT NULL
ORDER BY NumOfCustomers DESC

SELECT c.City,c.NumOfCustomers
FROM 
(
SELECT City, COUNT(CustomerID) AS NumOfCustomers
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID)>=2
) c
ORDER BY NumOfCustomers DESC

--18)
SELECT c.City, COUNT(od.ProductID) AS NumOfKindsOfProduct
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.City
HAVING COUNT(od.ProductID)>=2
ORDER BY NumOfKindsOfProduct 

--19)
SELECT t1.ProductID,t1.ProductName,t1.TotalQty,t1.AvgPrice,t2.City
FROM
(
SELECT TOP 5 p.ProductID,  p.ProductName, SUM(od.Quantity) AS TotalQty,(SUM((od.UnitPrice-od.Discount)*od.Quantity)/SUM(od.Quantity)) AS AvgPrice
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID JOIN Products p ON p.ProductID = od.ProductID
GROUP BY p.ProductID,p.ProductName
ORDER BY TotalQty DESC
)t1
JOIN
(
SELECT ct.City, ProductID
FROM
(
SELECT c.City,p.ProductID,od.Quantity, RANK() OVER(PARTITION BY p.ProductID ORDER BY od.Quantity DESC) RNK
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID JOIN Products p ON p.ProductID = od.ProductID
GROUP BY c.City,p.ProductID,od.Quantity
) ct
WHERE ct.RNK = 1
)t2 ON t1.ProductID = t2.ProductID
ORDER BY t1.TotalQty DESC

--20)
SELECT t1.City
FROM
(
SELECT TOP 1 e.EmployeeID,e.City, COUNT(o.OrderID) AS NumOfOrders
FROM Employees e JOIN Orders o ON e.EmployeeID = o.EmployeeID
GROUP BY e.EmployeeID,e.City
ORDER BY NumOfOrders DESC
) t1
JOIN
(
SELECT TOP 1 c.City, SUM(od.Quantity) AS TotalQty
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
ORDER BY TotalQty DESC
) t2 ON t1.City = t2.City

--21)
WITH cte AS
(
SELECT ... ROW_NUMBER()OVER(PARTITION BY ... ORDER BY ...) row_num
FROM ...
)
DELETE FROM cte
WHERE row_num > 1

