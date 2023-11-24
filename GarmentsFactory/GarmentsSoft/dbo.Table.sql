CREATE TABLE [dbo].[Table]
(
	[Client ID] INT NOT NULL PRIMARY KEY, 
    [Client Name] VARCHAR(50) NOT NULL, 
    [Client E-Mail] VARCHAR(50) NOT NULL, 
    [Client Company Name] NCHAR(10) NOT NULL, 
    [Client Trade License No] INT NOT NULL, 
    [Client Phone No] VARCHAR(50) NOT NULL, 
    [Client Address] VARCHAR(50) NOT NULL
)
