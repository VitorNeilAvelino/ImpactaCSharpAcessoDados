using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
        public void GroupByTeste()
        {
            using (var db = new OficinaEntities())
            {
                var agrupamento = db.Veiculo.GroupBy(v => v.AnoModelo).Select(g => new { AnoModelo = g.Key, Total = g.Count() });
                
                agrupamento = db.Veiculo.GroupBy(v => v.AnoModelo/*, v => v.Modelo.Descricao*/).Where(g => g.Count() > 1)
                    .Select(g => new { AnoModelo = g.Key, Total = g.Count() });

                foreach (var item in agrupamento)
                {
                    Console.WriteLine("{0} - {1}", item.Total, item.AnoModelo);
                }
            }
        }

        //ToDo: Não esquecer de diferenciar Where de Select.
    }
}