CREATE TABLE [dbo].[Cliente] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (200) NOT NULL,
    [Email]          VARCHAR (200) NULL,
    [DataNascimento] DATE          NOT NULL
);

