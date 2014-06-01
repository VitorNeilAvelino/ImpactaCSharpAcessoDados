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
                foreach (var veiculo in db.Servicos.ToList())
                {
                    Console.WriteLine(veiculo.Veiculo.Placa);
                }
                
                //var servicos = db.Servicos.OrderBy(s => s.Veiculo.Placa).ThenBy(s => s.DataInicio);

                //foreach (var servico in servicos)
                //{
                //    Console.WriteLine("{0} - {1}", servico.Veiculo.Placa, servico.DataInicio);
                //}
            }
        }
    }
}
