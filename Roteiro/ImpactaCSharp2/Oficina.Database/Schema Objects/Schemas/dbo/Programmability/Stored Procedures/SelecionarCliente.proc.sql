CREATE PROCEDURE [dbo].[SelecionarCliente]
	
	(
	@id int
	)
	
AS
begin
	Select Id, Nome, DataNascimento, Email From Cliente where Id = @id
	end
