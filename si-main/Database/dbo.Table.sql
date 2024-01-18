CREATE TABLE [dbo].[Vets]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [FullName] NVARCHAR(70) NOT NULL, 
    [Specialty] NVARCHAR(500) NULL, 
    [YearsExperience] INT NOT NULL
)
