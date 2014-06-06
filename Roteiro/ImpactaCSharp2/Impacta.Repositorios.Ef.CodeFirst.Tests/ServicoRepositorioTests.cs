using Impacta.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

        [TestMethod]
        public void InserirUowTest()
        {
            var servico = new Servico();
            servico.Sigla = "SIG";
            servico.TipoServico = new TipoServico { Descricao = "Higienização" };
            servico.DataInicio = DateTime.Now;

            using (var unitOfWork = new OficinaUnityOfWork())
            {
                servico.Veiculo = unitOfWork.VeiculoRepositorio.PesquisarPorPlaca("ABC1626");
                unitOfWork.ServicoRepositorio.Inserir(servico);

                //var veiculo = unitOfWork.VeiculoRepositorio.PesquisarPorPlaca("ETH6834");
                //veiculo.Servicos.Add(servico);

                unitOfWork.Salvar();
            }
        }

        [TestMethod]
        public void SelecionarTeste()
        {
            using (var unity = new OficinaUnityOfWork())
            {
                var servicos = unity.ServicoRepositorio.SelecionarPor(s => s.DataInicio.HasValue && s.DataInicio.Value.Month == 10);

                Assert.AreNotEqual(0, servicos.Count);
            }
        }

        [TestMethod]
        public void AtualizarTeste()
        {
            using (var unityOfWork = new OficinaUnityOfWork())
            {
                var veiculo = unityOfWork.VeiculoRepositorio.Selecionar(6);
                veiculo.AnoFabricacao = 2147;

                unityOfWork.Salvar();
            }
        }

        [TestMethod]
        public void ExcluirTeste()
        {
            using (var oficinaUoW = new OficinaUnityOfWork())
            {
                oficinaUoW.ServicoRepositorio.Excluir(3);
                oficinaUoW.Salvar();

                Assert.IsNull(oficinaUoW.ServicoRepositorio.Selecionar(3));
            }
        }
    }
}