using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Dominio.Testes
{
    [TestClass]
    public class VeiculoTest
    {
        [TestMethod]
        public void IndexadorVeiculoTeste()
        {
            var veiculos = new List<Veiculo>();
            veiculos.Add(new Veiculo { Id = 1, Placa = "ETH6834" });
            veiculos.Add(new Veiculo { Id = 2, Placa = "ETH6835" });

            foreach (var veiculo in veiculos)
            {
                if (veiculo["ETH6834"] != null)
                {
                    Console.WriteLine(veiculo.Id);
                }
            }

            var veiculoLambda = veiculos.FirstOrDefault(v => v.Placa == "ETH6834");
            if (veiculoLambda != null)
            {
                Console.WriteLine(veiculoLambda.Id);
            }
        }
    }
}