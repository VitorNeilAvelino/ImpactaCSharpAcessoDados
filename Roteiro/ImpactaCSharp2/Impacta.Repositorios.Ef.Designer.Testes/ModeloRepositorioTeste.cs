using System;
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
                              where m.Descricao == "Corsa"
                              select m;

                var montadora = new Montadora { Nome = "GM" };

                foreach (var modelo in modelos)
                {
                    modelo.Montadora = montadora;
                }

                db.SaveChanges();
            }
        }
    }
}