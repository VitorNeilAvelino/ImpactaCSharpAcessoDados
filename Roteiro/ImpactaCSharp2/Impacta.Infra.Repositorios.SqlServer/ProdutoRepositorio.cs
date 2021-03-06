﻿using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Impacta.Dominio;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Impacta.Repositorios.SqlServer.Proc
{
    public class ProdutoRepositorio : RepositorioBase
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
                    comando.CommandText = NomeProcedure.ExcluirProduto.ToString();

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
                    comando.CommandText = NomeProcedure.SelecionarProduto.ToString();
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

        public void Atualizar(Produto produto)
        {
            using (var conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosConnectionString"].ConnectionString))
            {
                conexao.Open();

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = NomeProcedure.AtualizarProduto.ToString();

                    foreach (var parametro in Mapear(produto))
                    {
                        comando.Parameters.Add(parametro);
                    }

                    comando.ExecuteNonQuery();
                }
            }
            //base.ExecuteNonQuery(NomeProcedure.AtualizarProduto, Mapear(produto));
        }

        private List<SqlParameter> Mapear(Produto produto)
        {
            var parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@id", produto.Id));
            parametros.Add(new SqlParameter("@descricao", produto.Descricao));
            parametros.Add(new SqlParameter("@custo", produto.Custo));
            parametros.Add(new SqlParameter("@tipoProduto_Id", produto.Tipo.Id));

            return parametros;
        }

        public List<Produto> Selecionar()
        {
            List<Produto> produtos = null;

            using (var conexao = PedidosConexao)
            {
                conexao.Open();

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = NomeProcedure.SelecionarProduto.ToString();

                    comando.Parameters.AddWithValue("@produtoId", DBNull.Value);

                    using (var registro = comando.ExecuteReader())
                    {
                        if (registro.HasRows)
                        {
                            produtos = new List<Produto>();

                            while (registro.Read())
                            {
                                produtos.Add(Mapear(registro));
                            }
                        }
                    }
                }
            }

            return produtos;
        }

        public List<Produto> SelecionarBase()
        {
            var parametros = new List<SqlParameter> { new SqlParameter("@produtoId", DBNull.Value) };

            return ExecuteReader<Produto>(NomeProcedure.SelecionarProduto, parametros, Mapear).ToList();
        }

        public void AtualizarComTransacao()
        {
            using (var conexao = PedidosConexao)
            {
                conexao.Open();

                // using: promove o rollback se o commit não for alcaçado.
                // IsolationLevel: The default is ReadCommitted.
                using (var transacao = conexao.BeginTransaction())
                {
                    var instrucao1 = "Update Produto set Descricao = 'Caneta' where Id = 3";
                    var instrucao2 = "Update Produto set Descricao = 'Lápis' where Id = 6";

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

                    //if (true)
                    //{
                    //    transacao.Rollback();
                    //}

                    transacao.Commit();
                }
            }
        }

        public int ContarProdutos()
        {
            return Convert.ToInt32(ExecuteScalar(NomeProcedure.ContarProdutos, null));
        }
    }
}