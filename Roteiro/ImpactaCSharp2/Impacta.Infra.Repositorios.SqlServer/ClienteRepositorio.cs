using System.Data;
using System.Data.SqlClient;
using Impacta.Infra.Apoio;
using Impacta.Dominio;

namespace Impacta.Infra.Repositorios.SqlServer.Procedures
{
    public class ClienteRepositorio
    {
        public DataTable Selecionar(string nomeCliente)
        {
            var dataTable = new DataTable();

            using (var conexao = new SqlConnection(BaseRepositorio.OficinaConnectionString))
            {
                conexao.Open();

                const string instrucao = @"SELECT [Id]
                      ,[Nome]
                      ,[Email]
                      ,[DataNascimento]
                      ,Tipo
                  FROM [Oficina].[dbo].[Cliente]
                  Where Nome like '%' + @nome + '%'";

                var comando = new SqlCommand(instrucao, conexao);
                comando.Parameters.AddWithValue("@nome", nomeCliente);

                var dataAdapter = new SqlDataAdapter(comando);
                dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        public Cliente Selecionar(int clienteId)
        {
            Cliente cliente = null;

            using (var conexao = new SqlConnection(BaseRepositorio.OficinaConnectionString))
            {
                conexao.Open();

                const string nomeProcedure = "SelecionarCliente";

                var comando = new SqlCommand(nomeProcedure, conexao);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", clienteId);

                var registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    cliente = new Cliente();
                    cliente.Id = registro["Id"].ParaInteiro();
                    cliente.Nome = registro["Nome"].ToString();
                    cliente.DataNascimento = registro["DataNascimento"].ParaData();
                    cliente.Email = registro["Email"].ToString();
                }
            }

            return cliente;
        }

        public void Atualizar(Cliente cliente)
        {
            using (var conexao = new SqlConnection(BaseRepositorio.OficinaConnectionString))
            {
                conexao.Open();

                const string nomeProcedure = "AtualizarCliente";

                var comando = new SqlCommand(nomeProcedure, conexao);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", cliente.Id);
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@dataNascimento", cliente.DataNascimento);
                comando.Parameters.AddWithValue("@email", cliente.Email);

                comando.ExecuteNonQuery();
            }
        }

        public void Excluir(int clienteId)
        {
            using (var conexao = new SqlConnection(BaseRepositorio.OficinaConnectionString))
            {
                conexao.Open();

                const string nomeProcedure = "ExcluirCliente";

                var comando = new SqlCommand(nomeProcedure, conexao);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", clienteId);

                comando.ExecuteNonQuery();
            }
        }
    }
}