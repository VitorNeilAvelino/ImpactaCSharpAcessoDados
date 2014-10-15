using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impacta.Apoio;
using Impacta.Dominio;
using System.Linq;

namespace Impacta.Apoio.Tests
{
    [TestClass()]
    public class ExtensoesTests
    {
        [TestMethod()]
        public void ParaListaTest()
        {
            var lista = new TipoCliente().ParaLista<TipoCliente>();

            foreach (var item in lista)
            {
                System.Console.WriteLine("{0} {1}", (int)item, item);
            }
        }
    }
}

namespace Impacta.Infra.Apoio.Tests
{
    [TestClass()]
    public class ExtensoesTests
    {
        [TestMethod()]
        public void ParaTipoTest()
        {
            int x = 42;
            string y = "43";

            x = y.ParaTipo<int>();

            Assert.AreEqual(43, x);
        }
    }
}