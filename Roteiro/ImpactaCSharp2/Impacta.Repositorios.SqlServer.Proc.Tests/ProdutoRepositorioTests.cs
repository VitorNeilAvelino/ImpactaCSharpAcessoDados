using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impacta.Repositorios.SqlServer.Proc;

namespace Impacta.Repositorios.SqlServer.Proc.Tests
{
    [TestClass()]
    public class ProdutoRepositorioTests
    {
         ProdutoRepositorio _repositorio = new ProdutoRepositorio();


        [TestMethod()]
        public void AtualizarComTransacaoTest()
        {
            _repositorio.AtualizarComTransacao();

            var produto = _repositorio.Selecionar(3);

            Assert.AreEqual(produto.Descricao, "Caneta - transação");
            Assert.AreNotEqual(produto.Descricao, "Caneta");
        }

        [TestMethod()]
        public void SelecionarTest()
        {
            var produtos = _repositorio.Selecionar();

            foreach (var produto in produtos)
            {
                System.Console.WriteLine(produto.Descricao);
            }
        }

        [TestMethod()]
        public void ContarProdutosTest()
        {
            System.Console.WriteLine(_repositorio.ContarProdutos());
        }
    }
}