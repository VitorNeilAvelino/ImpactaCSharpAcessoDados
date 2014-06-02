using Impacta.Infra.Repositorios.SqlServer.Procedures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Repositorios.SqlServer.Proc.Tests
{
    [TestClass]
    public class VeiculoRepositorioTests
    {
        [TestMethod]
        public void ExcluirTest()
        {
            using (var veiculoRepositorio = new VeiculoRepositorio())
            {
                //try
                //{
                veiculoRepositorio.Excluir(1);
                //}
                //catch 
                //{
                //    veiculoRepositorio.Conexao.Close();
                //    veiculoRepositorio.Conexao.Dispose();
                //    throw;
                //}
            }

            // O desenvolvedor pode esquecer de usar o using...
            //new VeiculoRepositorio().Excluir(1);
        }
    }
}