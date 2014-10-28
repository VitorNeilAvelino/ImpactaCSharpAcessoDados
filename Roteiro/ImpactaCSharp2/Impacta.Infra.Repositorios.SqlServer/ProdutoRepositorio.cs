using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Impacta.Dominio;
using System;

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

                const string instrucao = @"SELECT produto.id, 
                           produto.tipoproduto_id, 
                           produto.descricao, 
                           produto.custo, 
                           tipoproduto.descricao AS DescricaoTipoProduto 
                    FROM   produto 
                           INNER JOIN tipoproduto 
                                   ON produto.tipoproduto_id = tipoproduto.id 
                    WHERE  ( produto.descricao LIKE '%' + @descricao + '%' ) 
                    ORDER  BY produto.descricao";

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

        public void Excluir(int produtoId)
        {
            using (var conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosConnectionString"].ConnectionString))
            {
                conexao.Open();

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "ExcluirProduto";
                    comando.Parameters.AddWithValue("@produtoId", produtoId);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public Produto Selecionar(int produtoId)
        {
            Produto produto = null;

            using (var conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosConnectionString"].ConnectionString))
            {
                conexao.Open();

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "SelecionarProduto";
                    comando.Parameters.AddWithValue("@produtoId", produtoId);

                    using (var registro = comando.ExecuteReader())
                    {
                        if (registro.Read())
                        {
                            produto = Mapear(registro);
                        }
                    }
                }
            }

            return produto;
        }

        private Produto Mapear(SqlDataReader registro)
        {
            var produto = new Produto();

            produto.Id = Convert.ToInt32(registro["Id"]);
            produto.Descricao = registro["Descricao"].ToString();
            produto.Custo = Convert.ToDecimal(registro["Custo"]);

            produto.Tipo.Id = Convert.ToInt32(registro["IdTipoProduto"]);
            produto.Tipo.Descricao = registro["DescricaoTipoProduto"].ToString();

            return produto;
        }
    }
}