using Impacta.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}