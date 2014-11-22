using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Impacta.Repositorios.SqlServer.Proc
{
    public class RepositorioBase
    {
        public SqlConnection PedidosConexao
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosConnectionString"].ConnectionString);
            }
        }

        public void ExecuteNonQuery(NomeProcedure nomeProcedure, List<SqlParameter> parametros)
        {
            using (var conexao = PedidosConexao)
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

        protected IEnumerable<T> ExecuteReader<T>(NomeProcedure nomeProcedure, List<SqlParameter> parametros,
            Func<SqlDataReader, T> metodoDeMapeamento)
        {
            using (var conexao = PedidosConexao)
            using (var comando = conexao.CreateCommand())
            {
                conexao.Open();

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nomeProcedure.ToString();
                parametros.ForEach(p => comando.Parameters.Add(p));

                using (var registro = comando.ExecuteReader())
                {
                    while (registro.Read())
                    {
                        yield return metodoDeMapeamento(registro);
                    }
                }
            }
        }

        protected object ExecuteScalar(NomeProcedure nomeProcedure, List<SqlParameter> parametros)
        {
            using (var conexao = PedidosConexao)
            using (var comando = conexao.CreateCommand())
            {
                conexao.Open();

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nomeProcedure.ToString();

                if (parametros != null)
                {
                    parametros.ForEach(p => comando.Parameters.Add(p));
                }

                return comando.ExecuteScalar();
            }
        }
    }
}