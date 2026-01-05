CREATE TABLE [dbo].[OrderDetails]
(
	[OrderDetailsId] INT NOT NULL PRIMARY KEY IDENTITY,
	[OrderId] INT NOT NULL, 
	[ProductId] INT NOT NULL, 
	Quantity INT NOT NULL, 
	UnitPrice DECIMAL(10,2) NOT NULL, 
    CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY ([OrderId]) REFERENCES Orders(OrderId), 
    CONSTRAINT [FK_OrderDetails_Inventory] FOREIGN KEY ([ProductId]) REFERENCES Inventory(ProductId), 
)
