using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Impacta.Dominio.Testes
{
    [TestClass]
    public class VarianciaTestes
    {
        [TestMethod]
        public void CovarianciaTeste()
        {
            //var veiculo = new Veiculo();
            //var caminhao = new Caminhao();

            //veiculo = caminhao;
            ////caminhao = veiculo;

            //var veiculos = Selecionar<Veiculo>();
            //var caminhoes = Selecionar<Caminhao>();

            //veiculos = caminhoes;
            ////caminhoes = veiculos;
        }

        private static IEnumerable<T> Selecionar<T>()
        {
            return new List<T>();
        }
    }
}