CREATE TABLE [dbo].[KEYS]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [isSingleUse] BIT NOT NULL, 
    [reward] INT NOT NULL, 
    [isUsed] BIT NOT NULL, 
    [key] TEXT NOT NULL
)
