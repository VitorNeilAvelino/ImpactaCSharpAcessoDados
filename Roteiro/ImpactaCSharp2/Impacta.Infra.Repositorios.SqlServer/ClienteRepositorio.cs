using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Impacta.Infra.Apoio;
using Impacta.Dominio;
using System.Configuration;

namespace Impacta.Infra.Repositorios.SqlServer.Procedures
{
    public class ClienteRepositorio : BaseRepositorio, IClienteRepositorio
    {
        public DataTable Selecionar(string nomeCliente)
        {
            var dataTable = new DataTable();

            using (var conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["oficinaConnectionString"].ConnectionString))
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

        public void Inserir(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public Cliente Selecionar(int clienteId)
        {
            Cliente cliente = null;

            using (var conexao = new SqlConnection(OficinaConnectionString))
            {
                conexao.Open();

                const string nomeProcedure = "SelecionarCliente";

                using (var comando = new SqlCommand(nomeProcedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", clienteId);

                    using (var registro = comando.ExecuteReader())
                    {
                        if (registro.Read())
                        {
                            cliente = MapearCliente(registro);
                        }
                    }
                }
            }

            return cliente;
        }

        private static Cliente MapearCliente(SqlDataReader registro)
        {
            var cliente = new Cliente();
            cliente.Id = registro["Id"].ParaInteiro();
            cliente.Nome = registro["Nome"].ToString();
            cliente.DataNascimento = registro["DataNascimento"].ParaData();
            cliente.Email = registro["Email"].ToString();
            return cliente;
        }

        public void Atualizar(Cliente cliente)
        {
            using (var conexao = new SqlConnection(OficinaConnectionString))
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
            using (var conexao = new SqlConnection(OficinaConnectionString))
            {
                conexao.Open();

                const string nomeProcedure = "ExcluirCliente";

                using (var comando = new SqlCommand(nomeProcedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", clienteId);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Cliente> Selecionar()
        {
            var retorno = new List<Cliente>();

            using (var conexao = new SqlConnection(OficinaConnectionString))
            {
                conexao.Open();

                const string nomeProcedure = "SelecionarCliente";

                var comando = new SqlCommand(nomeProcedure, conexao);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", null);

                var registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    retorno.Add(MapearCliente(registros));
                }
            }

            return retorno;
        }

        public Cliente Atualizar(string nome, int id)
        {
            Comando.CommandText = string.Format("Update Cliente set Nome = @nome where Id = {0}", id);
            Comando.Parameters.AddWithValue("@nome", nome);
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();

            //throw new Exception();

            var cliente = new Cliente();
            Comando.CommandText = "SelecionarCliente";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@id", id);

            using (var registro = Comando.ExecuteReader())
            {
                if (registro.Read())
                {
                    cliente = MapearCliente(registro);
                }
            }

            return cliente;
        }

        public SqlDataReader RetornarDataReader(int id)
        {
            SqlDataReader cliente = null;

            //var conexao = new SqlConnection(OficinaConnectionString);
            using (var conexao = new SqlConnection(OficinaConnectionString))
            {
                conexao.Open();

                const string nomeProcedure = "SelecionarCliente";

                using (var comando = new SqlCommand(nomeProcedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);

                    var registro = comando.ExecuteReader();
                    registro.Read();
                    cliente = registro;
                }
            }

            return cliente;
        }

        public void AtualizarComTransacao()
        {
            using (var conexao = new SqlConnection(OficinaConnectionString))
            {
                conexao.Open();

                using(var transacao = conexao.BeginTransaction())
                {
                    var instrucao1 = "Update Cliente set Nome = 'Vítr' where Id = 1";
                    var instrucao2 = "Update Cliente set Nome = 'Avelino' where Id = 3";

                    using (var comando = conexao.CreateCommand())
                    {
                        comando.Transaction = transacao;
                        comando.CommandText = instrucao1;
                        comando.ExecuteNonQuery();
                    }

                    //throw new Exception();

                    using (var comando = conexao.CreateCommand())
                    {
                        comando.Transaction = transacao;
                        comando.CommandText = instrucao2;
                        comando.ExecuteNonQuery();
                    }

                    transacao.Commit();
                }
            }
        }
    }
}