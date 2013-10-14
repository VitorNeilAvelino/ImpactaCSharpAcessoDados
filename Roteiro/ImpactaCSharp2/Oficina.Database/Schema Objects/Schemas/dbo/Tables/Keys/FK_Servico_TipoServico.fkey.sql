ALTER TABLE [dbo].[Servico]
    ADD CONSTRAINT [FK_Servico_TipoServico] FOREIGN KEY ([TipoServico_Id]) REFERENCES [dbo].[TipoServico] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

