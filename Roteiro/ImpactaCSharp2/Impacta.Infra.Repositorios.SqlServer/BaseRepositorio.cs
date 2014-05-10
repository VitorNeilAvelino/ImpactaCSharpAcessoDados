using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Impacta.Infra.Repositorios.SqlServer.Procedures
{
    public abstract class BaseRepositorio : IDisposable
    {
        protected BaseRepositorio()
        {
            Conexao = new SqlConnection(OficinaConnectionString);
            Conexao.Open();
            Comando = Conexao.CreateCommand();
        }

        public SqlCommand Comando { get; set; }

        // Poderia ser private.
        public String OficinaConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["oficinaConnectionString"].ConnectionString;
            }
        }

        private SqlConnection Conexao { get; set; }

        // Se vem da interface, tem que ser publico.
        public void Dispose()
        {
            Conexao.Close();
            Comando.Dispose();
            Conexao.Dispose();
        }
    }
}