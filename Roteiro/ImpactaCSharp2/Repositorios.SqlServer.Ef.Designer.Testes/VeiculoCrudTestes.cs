using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impacta.Infra.Repositorios.SqlServer.Ef.Designer;

namespace Repositorios.SqlServer.Ef.Designer.Testes
{
    [TestClass]
    public class VeiculoCrudTestes
    {
        readonly OficinaEntities _contexto = new OficinaEntities();

        [TestMethod]
        public void InserirTeste()
        {
            var veiculo = new Veiculo();
            veiculo.AnoFabricacao = 2011;
            veiculo.AnoModelo = 2012;
            veiculo.Cor_Id = 2;
            veiculo.Modelo_Id = 1;
            veiculo.Placa = "ETH6834";

            _contexto.Veiculo.AddObject(veiculo);
            _contexto.SaveChanges();
        }

        [TestMethod]
        public void AtualizarTeste()
        {
            var veiculo = Selecionar("ETH6834");
            veiculo.AnoFabricacao = 2010;
            veiculo.AnoModelo = 2011;
            
            _contexto.SaveChanges();
        }

        [TestMethod]
        public void ExcluirTeste()
        {
            var veiculo = Selecionar("ETH6834");

            _contexto.DeleteObject(veiculo);
            _contexto.SaveChanges();
        }

        private Veiculo Selecionar(string placa)
        {
            var retornoLinq = from veiculo in _contexto.Veiculo
                              where veiculo.Placa == placa
                              select veiculo;

            var retornoLambda =  _contexto.Veiculo.Where(x => x.Placa == placa);
            
            //return retornoLinq.FirstOrDefault();
            return retornoLambda.FirstOrDefault();
        }
    }
}