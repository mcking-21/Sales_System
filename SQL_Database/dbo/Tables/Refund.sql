CREATE TABLE [dbo].[Refund]
(
	[RefundId] INT NOT NULL PRIMARY KEY, 
    [TransactionId] INT NOT NULL, 
	RefundAmount DECIMAL(10,2) NOT NULL, 
	RefundDate DATETIME DEFAULT GETDATE() NOT NULL, 
	Reason NVARCHAR(200) NULL, 
    CONSTRAINT [FK_Refund_Transaction] FOREIGN KEY ([TransactionId]) REFERENCES Transactions(TransactionId),
)
