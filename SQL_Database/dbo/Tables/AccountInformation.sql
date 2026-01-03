CREATE TABLE [dbo].[AccountInformation]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AccountId] INT NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [MiddleName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [MobileNumber] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_AccountInformation_Accounts] FOREIGN KEY (AccountId) REFERENCES [Accounts]([Id]), 
)
