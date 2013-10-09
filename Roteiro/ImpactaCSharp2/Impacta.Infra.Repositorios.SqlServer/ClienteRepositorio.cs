using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Impacta.Infra.Repositorios.SqlServer
{
    public class ClienteRepositorio
    {
        public DataTable Selecionar(string nomeCliente)
        {
            var conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["oficinaConnectionString"].ConnectionString);
            conexao.Open();

            const string instrucao = @"SELECT [Id]
                      ,[Nome]
                      ,[Email]
                      ,[DataNascimento]
                  FROM [Oficina].[dbo].[Cliente]
                  Where Nome like '%' + @nome + '%'";

            var comando = new SqlCommand(instrucao, conexao);
            comando.Parameters.AddWithValue("@nome", nomeCliente);

            var dataSet = new DataSet();

            var dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(dataSet);

            conexao.Close();

            return dataSet.Tables[0];
        }
    }
}