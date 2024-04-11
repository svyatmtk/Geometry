SELECT Product.ProductName AS productName, Category.CategoryName AS categoryName
FROM Product
LEFT JOIN ProductCategory ON Product.ProductId = ProductCategory.CategoryId
LEFT JOIN Category ON ProductCategory.CategoryId = Category.CategoryId;
