CREATE TABLE [dbo].[User] (
    [Id]     INT           NOT NULL,
    [Name]   NVARCHAR (50) NOT NULL,
    [Mobile] NVARCHAR (50) NOT NULL,
    [Email]  NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
