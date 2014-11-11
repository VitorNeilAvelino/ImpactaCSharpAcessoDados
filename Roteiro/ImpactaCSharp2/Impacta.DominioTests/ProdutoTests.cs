using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Dominio.Tests
{
    [TestClass()]
    public class ProdutoTests
    {
        [TestMethod()]
        public void ProdutoTest()
        {
            var produtos = new List<Produto>();
            produtos.Add(new Produto { Id = 1, Descricao = "Produto 1" });
            produtos.Add(new Produto { Id = 2, Descricao = "Produto 2" });

            foreach (var produto in produtos)
            {
                Console.WriteLine(produto[1] != null ? produto[1].Descricao : null);
            }

            Console.WriteLine(produtos.SingleOrDefault(p => p.Id == 1).Descricao);
        }
    }
}