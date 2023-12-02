CREATE TABLE [dbo].[Films] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [Director] NVARCHAR (MAX) NULL,
    [Price]    INT            NOT NULL,
    CONSTRAINT [PK_Films] PRIMARY KEY CLUSTERED ([Id] ASC)
);

