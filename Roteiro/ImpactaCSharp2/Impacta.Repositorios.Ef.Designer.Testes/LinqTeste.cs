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
                //var veiculos = db.Veiculo.OrderBy(v => v.AnoFabricacao);
                //var veiculos = db.Veiculo.OrderBy(v => v.AnoFabricacao).ThenBy(v => v.Modelo.Descricao);
                var veiculos = db.Veiculo.OrderByDescending(v => v.AnoFabricacao).ThenByDescending(v => v.Modelo.Descricao);

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine("{0} - {1} - {2}", veiculo.Placa, veiculo.AnoFabricacao, veiculo.Modelo.Descricao);
                }
            }
        }
    }
}