CREATE TABLE [dbo].[Servico] (
    [Id]             INT      IDENTITY (1, 1) NOT NULL,
    [Veiculo_Id]     INT      NOT NULL,
    [TipoServico_Id] INT      NOT NULL,
    [DataInicio]     DATETIME NULL,
    [DataFim]        DATETIME NULL
);

