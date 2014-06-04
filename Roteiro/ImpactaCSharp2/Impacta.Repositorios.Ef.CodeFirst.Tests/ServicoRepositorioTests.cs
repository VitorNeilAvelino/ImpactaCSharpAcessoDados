using Impacta.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Repositorios.Ef.CodeFirst.Tests
{
    [TestClass]
    public class ServicoRepositorioTests
    {
        [TestMethod]
        public void InserirTeste()
        {
            var servico = new Servico();
            servico.Sigla = "SIG";
            servico.TipoServico = new TipoServico { Descricao = "Martelinho_" };

            servico.Veiculo = new VeiculoRepositorio().PesquisarPorPlaca("ABC1626");
            new ServicoRepositorio().Inserir(servico);
        }

        //[TestMethod]
        //public void AtualizarTeste()
        //{
        //        var veiculo = unityOfWork.VeiculoRepositorio.Selecionar(6);
        //        veiculo.AnoFabricacao = 2147;
        //}

        [TestMethod]
        public void InserirUowTest()
        {
            var servico = new Servico();
            servico.Sigla = "SIG";
            servico.TipoServico = new TipoServico { Descricao = "Martelinho_" };

            using (var unitOfWork = new UnityOfWork())
            {
                servico.Veiculo = unitOfWork.VeiculoRepositorio.PesquisarPorPlaca("ABC1626");
                unitOfWork.ServicoRepositorio.Inserir(servico);

                unitOfWork.Salvar();
            }
        }

        [TestMethod]
        public void AtualizarUowTeste()
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