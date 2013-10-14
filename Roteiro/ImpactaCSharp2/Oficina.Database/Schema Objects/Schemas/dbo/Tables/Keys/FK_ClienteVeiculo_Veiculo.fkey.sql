ALTER TABLE [dbo].[ClienteVeiculo]
    ADD CONSTRAINT [FK_ClienteVeiculo_Veiculo] FOREIGN KEY ([Veiculo_Id]) REFERENCES [dbo].[Veiculo] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

