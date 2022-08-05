SELECT p.ProductName, c.CategoryName FROM Product AS p
LEFT JOIN Product_vs_Category AS pc ON pc.ProductID = p.ID
LEFT JOIN Category AS c ON pc.CategoryID = c.ID
ORDER BY p.ProductName, c.CategoryName