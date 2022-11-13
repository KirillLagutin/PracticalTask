-- Create tables
CREATE TABLE Products
(
    Id int NOT NULL PRIMARY KEY,
    ProductName nvarchar(100)
)

CREATE TABLE Categories
(
    Id int NOT NULL PRIMARY KEY,
    CategoryName nvarchar(100)
)

CREATE TABLE ProductCategories
(
    ProductId int NOT NULL FOREIGN KEY REFERENCES Products(Id),
    CategoryId int NOT NULL FOREIGN KEY REFERENCES Categories(Id)
)

-- SQL query
SELECT product.ProductName, category.CategoryName
FROM Products product
LEFT JOIN ProductCategories productCategory
       ON product.Id = productCategory.ProductId
LEFT JOIN Categories category
       ON productCategory.CategoryId = category.Id