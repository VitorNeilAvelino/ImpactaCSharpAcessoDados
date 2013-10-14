ALTER TABLE [dbo].[Servico]
    ADD CONSTRAINT [FK_Servico_Veiculo] FOREIGN KEY ([Veiculo_Id]) REFERENCES [dbo].[Veiculo] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

