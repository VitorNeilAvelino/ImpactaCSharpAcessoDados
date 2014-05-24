using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Repositorios.Ef.CodeFirst.Tests
{
    [TestClass()]
    public class OficinaDbContextTests
    {
        [TestMethod()]
        public void OrderByTeste()
        {
            using (var db = new OficinaDbContext())
            {
                var veiculos = db.Veiculos.OrderBy(v => v.AnoFabricacao).ThenByDescending(v => v.Placa);

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine("{0} - {1}", veiculo.AnoFabricacao, veiculo.Placa);
                }
            }
        }
    }
}
