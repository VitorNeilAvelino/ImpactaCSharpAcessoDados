using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Repositorios.SqlServer.Proc.Tests
{
    [TestClass()]
    public class ProdutoRepositorioTests
    {
        [TestMethod()]
        public void AtualizarComTransacaoTest()
        {
            var repositorio = new ProdutoRepositorio();

            repositorio.AtualizarComTransacao();

            var produto = repositorio.Selecionar(3);

            Assert.AreEqual(produto.Descricao, "Caneta - transação");
            Assert.AreNotEqual(produto.Descricao, "Caneta");
        }
    }
}