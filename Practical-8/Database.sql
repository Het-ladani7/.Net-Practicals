CREATE DATABASE InventoryDB;
GO
USE InventoryDB;
GO
CREATE TABLE Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL
);
GO
INSERT INTO Products (Name, Quantity, Price)
VALUES
('Laptop', 10, 55000),
('Mouse', 25, 500),
('Keyboard', 15, 1000);
GO
SELECT * FROM Products;
