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
            throw new System.NotImplementedException();
        }
    }
}