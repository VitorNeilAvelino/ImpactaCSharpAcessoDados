CREATE PROCEDURE AtualizarCliente
	@id int, @nome varchar(200), @email varchar(200), @dataNascimento datetime
AS
BEGIN
UPDATE [Oficina].[dbo].[Cliente]
   SET [Nome] = @nome
      ,[Email] = @email
      ,[DataNascimento] = @dataNascimento
 where Id = @id
END
