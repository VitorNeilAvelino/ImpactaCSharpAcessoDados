using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impacta.Infra.Repositorios.SqlServer.Ef.Designer;

namespace Repositorios.SqlServer.Ef.Designer.Testes
{
    [TestClass]
    public class VeiculoCrudTestes
    {
        OficinaEntities _contexto = new OficinaEntities();

        [TestMethod]
        public void InserirTeste()
        {
            var veiculo = new Veiculo();
            veiculo.AnoFabricacao = 2013;
            veiculo.AnoModelo = 2013;
            veiculo.Cor_Id = 2;
            veiculo.Modelo_Id = 1;
            veiculo.Placa = "ETH1507";

            _contexto.Veiculo.AddObject(veiculo);
            _contexto.SaveChanges();
        }
    }
}