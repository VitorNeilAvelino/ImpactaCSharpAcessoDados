CREATE TABLE [dbo].[Veiculo] (
    [Id]            INT      IDENTITY (1, 1) NOT NULL,
    [Modelo_Id]     INT      NOT NULL,
    [Cor_Id]        INT      NOT NULL,
    [Placa]         CHAR (7) NOT NULL,
    [AnoFabricacao] INT      NOT NULL,
    [AnoModelo]     INT      NOT NULL
);

