using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
namespace Impacta.Repositorios.Ef.Designer.Testes
{
    [TestClass]
    public class VeiculoRepositorioTeste
    {
        [TestMethod]
        public void InserirTeste()
        {
            var db = new OficinaEntities();

            using (OficinaEntities contexto = new OficinaEntities())
            {
                var veiculo = new Veiculo();
                veiculo.AnoFabricacao = 2013;
                veiculo.AnoModelo = 2014;
                veiculo.Cor = contexto.Cor.Single(c => c.Id == 1);
                veiculo.Modelo = contexto.Modelo.Single(m => m.Id == 1);
                veiculo.Placa = "FIB6967";

                contexto.Veiculo.Add(veiculo);
                contexto.SaveChanges();
            }
        }
    }
}