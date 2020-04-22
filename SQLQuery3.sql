CREATE DATABASE [MovieAPI]
GO
USE [MovieAPI]
GO
CREATE TABLE [Movie](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [MovieTitle] [nvarchar](50) NOT NULL,
     [Category] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT INTO [Movie] ([MovieTitle], [Category]) 
VALUES 
(N'The One', N'Action'), 
(N'Memento', N'Thiller'),
(N'Inception', N'Thiller'),
(N'Die Hard', N'Chirtmas Movie'),
(N'Rent', N'Musical'),
(N'Step Brothers', N'Comedy'),
(N'Gladiator', N'Action'),
(N'How the Grinch Stole Christmas', N'Christmas Movie'),
(N'Grandma got ranover by a Reindeer', N'Christmas Movie'),
(N'Blades of Glory', N'Comedy'),
(N'Endgame', N'Action'),
(N'The Shining', N'Thiller'),
(N'The Hangover', N'Comdey'),
(N'The Raid', N'Action')
GO