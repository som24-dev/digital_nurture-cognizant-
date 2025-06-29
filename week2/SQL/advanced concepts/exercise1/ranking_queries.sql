-- 1. Create the Products table
CREATE TABLE Products (
    ProductID INT,
    ProductName VARCHAR(100),
    Category VARCHAR(100),
    Price DECIMAL(10,2)
);

-- 2. Insert some sample data (optional)
INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Laptop', 'Electronics', 800.00),
(2, 'Smartphone', 'Electronics', 600.00),
(3, 'TV', 'Electronics', 1200.00),
(4, 'Pen', 'Stationery', 2.50),
(5, 'Notebook', 'Stationery', 5.00),
(6, 'Marker', 'Stationery', 4.00),
(7, 'Headphones', 'Electronics', 600.00);

-- 3. ROW_NUMBER: Top 3 most expensive products per category
SELECT * FROM (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
) AS Ranked
WHERE RowNum <= 3;

-- 4. RANK: Shows ties and gaps
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankInCategory
FROM Products;

-- 5. DENSE_RANK: Shows ties without gaps
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRank
FROM Products;
