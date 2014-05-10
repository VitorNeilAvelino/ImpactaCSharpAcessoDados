using Impacta.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impacta.Infra.Repositorios.SqlServer.Procedures;

namespace Impacta.Infra.Repositorios.SqlServer.Procedures.Tests
{
    [TestClass()]
    public class ClienteRepositorioTests
    {
        [TestMethod()]
        public void AtualizarTest()
        {
            Cliente cliente;

            //var repositorio = new ClienteRepositorio();

            using (var repositorio = new ClienteRepositorio())
            {
                cliente = repositorio.Atualizar("Nome", 1); 
            }

            Assert.AreEqual(cliente.Nome, "Nome");

            //System.Console.WriteLine(cliente.Nome);
        }

        [TestMethod()]
        public void RetornarDataReaderTest()
        {
            var cliente = new ClienteRepositorio().RetornarDataReader(1);

            Assert.AreEqual(cliente["Id"], 1);
        }

        [TestMethod()]
        public void AtualizarComTransacaoTest()
        {
            var repositorio = new ClienteRepositorio();
            
            repositorio.AtualizarComTransacao();

            var cliente = repositorio.Selecionar(3);

            Assert.AreEqual(cliente.Nome, "Avelino");
        }
    }
}