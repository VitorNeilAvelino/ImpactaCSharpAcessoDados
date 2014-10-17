using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Impacta.Repositorios.SqlServer.Proc
{
    public class ProdutoRepositorio
    {
        public DataTable Selecionar(string descricao)
        {
            var dataTable = new DataTable();

            using (var conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosConnectionString"].ConnectionString))
            {
                conexao.Open();

                /*
                 SELECT [id], 
                           [descricao], 
                           [tipo], 
                           CASE 
                             WHEN tipo = 1 THEN 'Papelaria' 
                             WHEN tipo = 2 THEN 'Presentes' 
                             WHEN tipo = 3 THEN 'Brinquedos' 
                           END AS DescricaoTipo, 
                           [custo] 
                    FROM   [dbo].[produto] 
                    WHERE  descricao LIKE '%' + @descricao + '%'   
                 */

                const string instrucao = @"SELECT [Id]
                      ,[Descricao]
                      ,[Tipo]
                      ,[Custo]
                    FROM [dbo].[Produto]
                    Where Descricao like '%' + @descricao + '%'
                    Order by Descricao";

                using (var comando = new SqlCommand(instrucao, conexao))
                {
                    comando.Parameters.AddWithValue("@descricao", descricao);

                    using (var dataAdapter = new SqlDataAdapter(comando))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }
}