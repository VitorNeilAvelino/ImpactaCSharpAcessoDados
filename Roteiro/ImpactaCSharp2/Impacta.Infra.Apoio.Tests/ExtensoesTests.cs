using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impacta.Apoio;

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