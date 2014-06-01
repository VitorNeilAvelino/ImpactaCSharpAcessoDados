using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace Impacta.Repositorios.Ef.Designer.Testes
{
    [TestClass]
    public class LinqTeste
    {
        [TestMethod]
        public void OrderByTeste()
        {
            using (var db = new OficinaEntities())
            {
                //var lista = from veiculo in _contexto.Veiculo
                //            //orderby veiculo.AnoModelo descending, veiculo.Modelo.Descricao
                //            orderby veiculo.AnoModelo
                //            select veiculo;

                //var veiculos = db.Veiculo.OrderBy(v => v.AnoFabricacao);
                //var veiculos = db.Veiculo.OrderBy(v => v.AnoFabricacao).ThenBy(v => v.Modelo.Descricao);
                var veiculos = db.Veiculo.OrderBy(v => new { v.AnoFabricacao, v.Modelo.Descricao });
                //var veiculos = db.Veiculo.OrderByDescending(v => v.AnoFabricacao).ThenByDescending(v => v.Modelo.Descricao);

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine("{0} - {1} - {2}", veiculo.Placa, veiculo.AnoFabricacao, veiculo.Modelo.Descricao);
                }
            }
        }

        [TestMethod]
        public void CountTeste()
        {
            using (var db = new OficinaEntities())
            {
                Console.WriteLine(db.Veiculo.Count());
                Console.WriteLine(db.Veiculo.Count(v => v.AnoFabricacao == 2014));
            }
        }

        [TestMethod]
        public void MinTeste()
        {
            using (var db = new OficinaEntities())
            {
                Console.WriteLine("Menor data de nascimento: {0}", db.Cliente.Min(c => c.DataNascimento));

                var clienteMaisAntigo = db.Cliente.OrderBy(c => c.DataNascimento).First();
                Console.WriteLine("Cliente mais antigo: {0} - {1}", clienteMaisAntigo.Nome, clienteMaisAntigo.DataNascimento);
            }
        }

        [TestMethod]
        public void LikeTeste()
        {
            using (var db = new OficinaEntities())
            {
                db.Modelo
                    .Where(m => m.Descricao.Contains("c"))
                    .Where(m => m.Descricao.StartsWith("c"))
                    .Where(m => m.Descricao.EndsWith("c"))
                    .ToList()
                    .ForEach(m => Console.WriteLine(m.Descricao));
            }
        }

        [TestMethod]
        public void GroupByTeste()
        {
            using (var db = new OficinaEntities())
            {
                var agrupamento = db.Veiculo
                    .GroupBy(v => v.AnoModelo)
                    .Select(g => new { AnoModelo = g.Key, Total = g.Count() });

                agrupamento = db.Veiculo
                    .GroupBy(v => v.AnoModelo)
                    .Where(g => g.Count() > 1)
                    .Select(g => new { AnoModelo = g.Key, Total = g.Count() });

                var agrupamentoComDescricao = db.Veiculo
                    .GroupBy(v => new { v.AnoModelo, v.Modelo.Descricao })
                    .Select(g => new { AnoModelo = g.Key.AnoModelo, Descricao = g.Key.Descricao, Total = g.Count() });

                foreach (var item in agrupamentoComDescricao)
                {
                    Console.WriteLine("{0} - {1} - {2}", item.Total, item.AnoModelo, item.Descricao);
                }

                var agrupamentoSoma = db.Servico
                    .GroupBy(s => s.Veiculo)
                    .Select(g => new { g.Key.Placa, Total = g.Sum(s => s.Valor) });

                foreach (var veiculo in agrupamentoSoma)
                {
                    Console.WriteLine("{0} - {1}", veiculo.Placa, veiculo.Total);
                }
            }
        }

        [TestMethod]
        public void DistinctTeste()
        {
            using (var db = new OficinaEntities())
            {
                foreach (var cor in db.Veiculo.Select(v => v.Cor).Distinct())
                {
                    Console.WriteLine(cor.Descricao);
                }
            }
        }

        [TestMethod]
        public void JoinTeste()
        {
            var veiculos = new[] { 
                new { Placa = "ABC1111", ModeloId = 1 }, 
                new { Placa = "ABC2222", ModeloId = 2 }, 
                new { Placa = "ABC3333", ModeloId = 3 } 
            };
            var modelos = new[] { 
                new { Id = 1, Descricao = "Fiesta" }, 
                new { Id = 2, Descricao = "Corsa" } 
            };

            var consulta = veiculos.Join(
                modelos,
                v => v.ModeloId,
                m => m.Id,
                (v, m) => new { Placa = v.Placa, Modelo = m.Descricao });

            foreach (var item in consulta)
            {
                Console.WriteLine("{0} - {1}", item.Placa, item.Modelo);
            }
        }

        [TestMethod]
        public void SelectManyTeste()
        {
            using (var db = new OficinaEntities())
            {
                foreach (var servico in db.Veiculo.Select(v => v.Servico))
                {
                    Console.WriteLine(servico);
                }
                foreach (var servico in db.Veiculo.SelectMany(v => v.Servico))
                {
                    Console.WriteLine(servico.Valor);
                }
            }
        }

        [TestMethod]
        public void LeftJoinTeste()
        {
            var veiculos = new[] { 
                new { Placa = "ABC1111", ModeloId = 1 }, 
                new { Placa = "ABC2222", ModeloId = 2 }, 
                new { Placa = "ABC3333", ModeloId = 3 } 
            };
            var modelos = new[] { 
                new { Id = 1, Descricao = "Fiesta" }, 
                new { Id = 2, Descricao = "Corsa" } 
            };

            var consulta = veiculos.GroupJoin(
                modelos,
                v => v.ModeloId,
                m => m.Id,
                (v, ms) => new { Veiculo = v, Modelos = ms.DefaultIfEmpty() })
                .SelectMany(join => join.Modelos.Select(m => new { Placa = join.Veiculo.Placa, Modelo = m != null ? m.Descricao : null }));

            foreach (var item in consulta)
            {
                Console.WriteLine("{0} - {1}", item.Placa, item.Modelo);
            }

            //foreach (var item in consulta)
            //{
            //    var modelo = item.Modelos.SingleOrDefault(m => m != null && m.Id == item.Veiculo.ModeloId);
            //    Console.WriteLine("{0} - {1}", item.Veiculo.Placa, modelo != null ? modelo.Descricao : null);
            //}
        }
        
        // Transação
        //SQL
        // SEM LAMBDA
        //quando vai ao banco?
    }
}