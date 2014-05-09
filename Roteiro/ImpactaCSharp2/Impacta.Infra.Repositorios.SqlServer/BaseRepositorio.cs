using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Impacta.Infra.Repositorios.SqlServer.Procedures
{
    public class BaseRepositorio : IDisposable
    {
        public BaseRepositorio()
        {
            Conexao = new SqlConnection(OficinaConnectionString);
            Conexao.Open();
            Comando = Conexao.CreateCommand();
        }

        public SqlCommand Comando { get; set; }

        public String OficinaConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["oficinaConnectionString"].ConnectionString;
            }
        }

        public SqlConnection Conexao { get; set; }

        public void Dispose()
        {
            Conexao.Close();
            Comando.Dispose();
            Conexao.Dispose();
        }
    }
}