ALTER TABLE [dbo].[ClienteVeiculo]
    ADD CONSTRAINT [FK_ClienteVeiculo_Cliente] FOREIGN KEY ([Cliente_Id]) REFERENCES [dbo].[Cliente] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

