﻿ALTER TABLE [dbo].[Veiculo]
    ADD CONSTRAINT [FK_Veiculo_Cor] FOREIGN KEY ([Cor_Id]) REFERENCES [dbo].[Cor] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
