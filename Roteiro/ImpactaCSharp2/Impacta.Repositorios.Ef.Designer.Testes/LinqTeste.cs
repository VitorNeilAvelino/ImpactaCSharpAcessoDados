using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Repositorios.Ef.Designer.Testes
{
    [TestClass]
    public class LinqTeste
    {
        [TestMethod]
        public void OrderByTeste()
        {
            using (var db = new PedidosEntities())
            {
                var sql = "Select * from Produto order by Descricao, Custo desc";

                var produtos = from p in db.Produto
                               orderby p.Descricao
                               orderby p.Custo descending
                               select p;

                //var produtosLambda = db.Produto.OrderBy(p => p.Id).OrderByDescending(p => p.Custo).ThenBy( p => p.Id);
                var produtosLambda = db.Produto.OrderBy(p => new { p.Id, p.Descricao });


                foreach (var produto in produtos)
                {
                    Console.WriteLine("{0} - {1}", produto.Id, produto.Descricao);
                }

                Console.WriteLine(new string('-', 50));

                foreach (var produto in produtosLambda)
                {
                    Console.WriteLine("{0} - {1}", produto.Id, produto.Descricao);
                }

                var produtosSql = db.Database.SqlQuery<Produto>(sql);

                Console.WriteLine(new string('-', 50));

                foreach (var produto in produtosSql)
                {
                    Console.WriteLine("{0} - {1} - {2}", produto.Id, produto.Descricao, produto.Custo);
                }
            }
        }

        [TestMethod]
        public void CountTeste()
        {
            using (var db = new PedidosEntities())
            {
                var sql = "Select Count(*) from Produto";

                var quantidadeProdutos = (from p in db.Produto
                                          select p).Count();

                var quantidadeLambda = db.Produto.Count(p => p.TipoProduto.Descricao == "Papelaria");
                var quantidadeLambdaEquals = db.Produto.Count(p => p.TipoProduto.Descricao.Equals("Papelaria"));

                var quantidadeSql = db.Database.SqlQuery<int>(sql).FirstOrDefault();

                Console.WriteLine("{0} - {1} - {2} - {3}", quantidadeProdutos, quantidadeLambda, quantidadeSql, quantidadeLambdaEquals);
            }
        }

        [TestMethod]
        public void LikeTeste()
        {
            using (var db = new PedidosEntities())
            {
                var sql = "Select * from Produto where Descricao like '%p%'";

                var produtos = from p in db.Produto
                               where p.Descricao.Contains("can")
                               select p;

                var produtosLambda = db.Produto.Where(p => p.Descricao.Contains("bor"));

                var produtosSql = db.Database.SqlQuery<Produto>(sql);

                foreach (var produto in produtosSql)
                {
                    Console.WriteLine(produto.Descricao);
                }
            }
        }

        [TestMethod]
        public void MinTeste()
        {
            using (var db = new PedidosEntities())
            {
                var sql = "Select Min(Custo) from Produto";

                var maiorCusto = (from p in db.Produto
                                  select p).Max(p => p.Custo);

                var custoMedio = db.Produto.Average(p => p.Custo);

                var soma = db.Produto.Sum(p => (p.Custo * 1.1m));

                var menorCusto = db.Database.SqlQuery<decimal>(sql).FirstOrDefault();

                Console.WriteLine("{0} - {1} - {2} - {3}", maiorCusto, custoMedio, menorCusto, soma);
            }
        }

        [TestMethod]
        public void GroupByTeste()
        {
            using (var db = new PedidosEntities())
            {
                var sql = @"Select Count(P.TipoProduto_Id) as Total, TP.Descricao as Tipo from Produto P 
                            inner join TipoProduto TP on TP.Id = P.TipoProduto_Id
                            group by TP.Id, TP.Descricao";

                var agrupamento = from p in db.Produto
                                  group p by p.TipoProduto into grupo
                                  //orderby grupo.Key.Descricao
                                  //where grupo.Count() > 1
                                  select new { Tipo = grupo.Key.Descricao, Total = grupo.Count() };

                var agrupamentoLambda = db.Produto.GroupBy(p => p.TipoProduto).Select(grupo => new { Tipo = grupo.Key.Descricao, Total = grupo.Count() });

                var agrupamentoSql = db.Database.SqlQuery<Agrupamento>(sql);

                foreach (var item in agrupamentoSql)
                {
                    Console.WriteLine("{0}: {1}", item.Tipo, item.Total);
                }
            }
        }

        [TestMethod]
        public void DistinctTeste()
        {
            using (var db = new PedidosEntities())
            {
                var sql = @"Select distinct TP.Descricao from Produto P 
                            inner join TipoProduto TP on TP.Id = P.TipoProduto_Id";

                var tiposDistintos = (from p in db.Produto
                                      select p.TipoProduto.Descricao).Distinct();

                var tiposDistintosLambda = db.Produto.Select(p => p.TipoProduto.Descricao).Distinct();

                var tiposDistintosSql = db.Database.SqlQuery<string>(sql);

                foreach (var tipo in tiposDistintos)
                {
                    Console.WriteLine(tipo);
                }
            }
        }

        [TestMethod]
        public void InTeste()
        {
            using (var db = new PedidosEntities())
            {
                var sql = @"Select * from Produto where Id in(1, 6, 5, 9)";

                var listaIds = new[] { 1, 6, 5, 9 };

                var produtos = from p in db.Produto
                               where listaIds.Contains(p.Id)
                               select p;

                var produtosLambda = db.Produto.Where(p => listaIds.Contains(p.Id));

                var produtosSql = db.Database.SqlQuery<Produto>(sql);

                foreach (var produto in produtosSql)
                {
                    Console.WriteLine("{0} - {1}", produto.Id, produto.Descricao);
                }
            }
        }

        [TestMethod]
        public void UnionTeste()
        {
            using (var db = new PedidosEntities())
            {
                var sql = @"Select * from Produto where Id in(1, 6, 5, 9)
                            union /*all*/ Select * from Produto where Id in(6, 17, 11)";

                var listaIds1 = new[] { 1, 6, 5, 9 };
                var listaIds2 = new[] { /*6,*/ 17, 11 };

                var produtos1 = from p in db.Produto
                                where listaIds1.Contains(p.Id)
                                select p;

                var produtos2 = from p in db.Produto
                                where listaIds2.Contains(p.Id)
                                select p;

                var produtos = produtos1.Union(produtos2);

                var produtosLambda = db.Produto.Where(p => listaIds1.Contains(p.Id))
                    .Union(db.Produto.Where(p => listaIds2.Contains(p.Id)));
                //.Concat(db.Produto.Where(p => listaIds2.Contains(p.Id)));

                var produtosSql = db.Database.SqlQuery<Produto>(sql);

                foreach (var produto in produtos)
                {
                    Console.WriteLine("{0} - {1}", produto.Id, produto.Descricao);
                }
            }
        }

        [TestMethod]
        public void TakeTeste()
        {
            using (var db = new PedidosEntities())
            {
                var sql = @"Rodar o Express Profiler";

                var produtos = (from p in db.Produto
                                orderby p.Descricao
                                select p).Skip(5).Take(5);

                var produtosLambda = db.Produto.OrderBy(p => p.Descricao).Skip(2).Take(2);

                foreach (var produto in produtosLambda)
                {
                    Console.WriteLine("{0} - {1}", produto.Id, produto.Descricao);
                }
            }
        }

        [TestMethod]
        public void WhereVsSelectTeste()
        {
            using (var db = new PedidosEntities())
            {
                const string sqlWhere = @"Select * from Produto where Custo > 12.50";
                const string sqlSelect = "Select Id, Descricao from Produto";

                var produtosWhere = from p in db.Produto
                                    where p.Custo > 12.5M
                                    select p;

                var produtosSelect = from p in db.Produto
                                     select new { p.Id, p.Descricao };

                var whereLambda = db.Produto.Where(p => p.Custo > 12.5M);
                var selectLambda = db.Produto.Select(p => new { p.Id, p.Descricao });

                var produtosSql = db.Database.SqlQuery<Produto>(sqlSelect); // Erro: propriedade Custo não encontrada.

                foreach (var produto in produtosSql)
                {
                    Console.WriteLine("{0} - {1}", produto.Id, produto.Descricao);
                }
            }
        }

        [TestMethod]
        public void JoinTeste()
        {
            var veiculos = new[] { 
                            new { Placa = "ABC1111", Modelo_Id = 1 }, 
                            new { Placa = "ABC2222", Modelo_Id = 2 }, 
                            new { Placa = "ABC3333", Modelo_Id = 3 } 
                        };

            var modelos = new[] { 
                            new { Id = 1, Descricao = "Fiesta" }, 
                            new { Id = 2, Descricao = "Corsa" } 
                        };

            var consulta = from v in veiculos
                           join m in modelos on v.Modelo_Id equals m.Id
                           select new { Placa = v.Placa, Modelo = m.Descricao };

            var consultaLambda = veiculos.Join(
                modelos,
                v => v.Modelo_Id,
                m => m.Id,
                (v, m) => new { Placa = v.Placa, Modelo = m.Descricao });

            foreach (var item in consulta)
            {
                Console.WriteLine("{0} - {1}", item.Placa, item.Modelo);
            }
        }

        [TestMethod]
        public void LeftJoinTeste()
        {
            var veiculos = new[] { 
                            new { Placa = "ABC1111", Modelo_Id = 1 }, 
                            new { Placa = "ABC2222", Modelo_Id = 2 }, 
                            new { Placa = "ABC3333", Modelo_Id = 3 } 
                        };

            var modelos = new[] { 
                            new { Id = 1, Descricao = "Fiesta" }, 
                            new { Id = 2, Descricao = "Corsa" } 
                        };

            var consulta = from v in veiculos
                           join m in modelos on v.Modelo_Id equals m.Id into modeloJoin
                           from mj in modeloJoin.DefaultIfEmpty()
                           select new
                           {
                               Placa = v.Placa,
                               Modelo = (mj == null ? string.Empty : mj.Descricao)
                           };

            foreach (var item in consulta)
            {
                Console.WriteLine("{0} - {1}", item.Placa, item.Modelo);
            }
        }
    }
}