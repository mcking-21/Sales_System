CREATE TABLE [dbo].[Inventory]
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(50) NOT NULL,
    [ProductImage] varbinary(MAX) NULL,
    [QuantityInStock] INT NOT NULL, 
    [LastUpdated] DATETIME default GETDATE() NOT NULL, 
)
