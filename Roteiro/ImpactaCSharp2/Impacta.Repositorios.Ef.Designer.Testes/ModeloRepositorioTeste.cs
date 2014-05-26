using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Impacta.Repositorios.Ef.Designer.Testes
{
    [TestClass]
    public class ModeloRepositorioTeste
    {
        [TestMethod]
        public void AtualizarModeloTeste()
        {
            using (var db = new OficinaEntities())
            {
                var modelos = from m in db.Modelo
                              where m.Descricao == "C4"
                              select m;

                var montadora = new Montadora { Nome = "Ford" };

                foreach (var modelo in modelos)
                {
                    modelo.Montadora = montadora;
                }

                //db.Modelo.Where(m => m.Descricao == "Palio").ToList().ForEach(m => m.Montadora = new Montadora { Nome = "Fiat" });

                //var coisa = db.Veiculo.Where(v => v.Placa == "ETH6834").Select(v => new { v.Placa, v.AnoFabricacao }).Single();
                //Assert.AreEqual(coisa.Placa, "ETH6834");
                
                db.SaveChanges();
            }
        }
    }
}