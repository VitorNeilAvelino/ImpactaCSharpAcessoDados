using Impacta.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Repositorios.Ef.CodeFirst.Tests
{
    [TestClass()]
    public class ServicoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
            var servico = new Servico();
            servico.Sigla = "SIG";
            servico.TipoServico = new TipoServico { Descricao = "Martelinho" };

            using (var unitOfWork = new UnityOfWork())
            {
                servico.Veiculo = unitOfWork.VeiculoRepositorio.PesquisarPorPlaca("ETH6834");
                unitOfWork.ServicoRepositorio.Inserir(servico);

                unitOfWork.Salvar();
            }
        }

        [TestMethod]
        public void AtualizarTeste()
        {
            using (var unityOfWork = new UnityOfWork())
            {
                var veiculo = unityOfWork.VeiculoRepositorio.Selecionar(6);
                veiculo.AnoFabricacao = 2147;

                unityOfWork.Salvar();
            }
        }
    }
}