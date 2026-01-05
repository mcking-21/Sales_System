CREATE TABLE [dbo].[Returns]
(
	[ReturnId] INT NOT NULL PRIMARY KEY,
	[TransactionId] INT NOT NULL, 
	[ProductId] INT NOT NULL, 
	QuantityReturned INT NOT NULL, 
	ReturnDate DATETIME DEFAULT GETDATE() NOT NULL, 
	Reason NVARCHAR(200) NULL, 
    CONSTRAINT [FK_Returns_Transaction] FOREIGN KEY ([TransactionId]) REFERENCES Transactions(TransactionId), 
    CONSTRAINT [FK_Returns_Inventory] FOREIGN KEY (ProductId) REFERENCES Inventory(ProductId),
)
