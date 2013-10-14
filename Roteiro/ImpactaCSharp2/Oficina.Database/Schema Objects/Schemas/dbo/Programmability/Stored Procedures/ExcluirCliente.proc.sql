CREATE PROCEDURE ExcluirCliente 
		@id int

AS
BEGIN
	Delete Cliente where id = @id
END
