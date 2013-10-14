ALTER TABLE [dbo].[Veiculo]
    ADD CONSTRAINT [FK_Veiculo_Modelo] FOREIGN KEY ([Modelo_Id]) REFERENCES [dbo].[Modelo] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

