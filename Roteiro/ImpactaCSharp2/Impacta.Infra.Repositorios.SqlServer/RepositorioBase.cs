using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Impacta.Repositorios.SqlServer.Proc
{
    public class RepositorioBase
    {
        public void ExecuteNonQuery(NomeProcedure nomeProcedure, List<SqlParameter> parametros)
        {
            using (var conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosConnectionString"].ConnectionString))
            {
                conexao.Open();

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = nomeProcedure.ToString();
                    
                    foreach (var parametro in parametros)
                    {
                        comando.Parameters.Add(parametro);
                    }
                    
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}