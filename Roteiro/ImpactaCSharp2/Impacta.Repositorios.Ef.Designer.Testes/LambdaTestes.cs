using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Impacta.Repositorios.Ef.Designer.Testes
{
    [TestClass]
    public class LambdaTestes
    {
        //public delegate bool Filtro(Produto produto, object valor);
        public delegate bool Filtro<T>(Produto produto, T valor);

        // 5o.
        [TestMethod]
        public void FiltrarProdutoTeste()
        {
            var produtos = new List<Produto>();

            produtos.Add(new Produto { Id = 1, Descricao = "Borracha" });
            produtos.Add(new Produto { Id = 2, Descricao = "Lápis" });
            produtos.Add(new Produto { Id = 3, Descricao = "Caneta" });
            produtos.Add(new Produto { Id = 4, Descricao = "Apagador" });

            //var produtosPorId = FiltrarPorId(_produtos, 2);
            //var produtosPorDescricao = FiltrarPorDescricao(_produtos, "c");

            var produtosPorId = Filtrar(produtos, 2, FiltrarPorId);
            var produtosPorDescricao = Filtrar(produtos, "e", FiltrarPorDescricao);

            produtosPorId = Filtrar(produtos, 1, delegate(Produto produto, int id) { return produto.Id == id; /* return FiltrarPorId(produto, id)*/ });
            produtosPorId = Filtrar(produtos, 1, (Produto produto, int id) => { return produto.Id == id; });
            
            var produtoFind = produtos.Find(delegate(Produto produto) { return produto.Id == 2; });
            Console.WriteLine("{0} - {1}", produtoFind.Id, produtoFind.Descricao);

            produtosPorId = produtos.Where((Produto p) => p.Descricao.Contains("i")).ToList();

            foreach (var produto in produtosPorId)
            {
                Console.WriteLine("{0} - {1}", produto.Id, produto.Descricao);
            }
        }

        // 4o.
        public List<Produto> Filtrar<T>(List<Produto> produtos, T valor, Filtro<T> filtro)
        {
            var retorno = new List<Produto>();

            foreach (var produto in produtos)
            {
                if (filtro(produto, valor))
                {
                    retorno.Add(produto);
                }
            }

            return retorno;
        }

        public bool FiltrarPorId(Produto produto, int id)
        {
            return produto.Id == id;
        }

        public bool FiltrarPorDescricao(Produto produto, string descricao)
        {
            return produto.Descricao.Contains(descricao);
        }

        //// 3o.
        //public List<Produto> Filtrar(List<Produto> produtos, object valor)
        //{
        //    var retorno = new List<Produto>();

        //    foreach (var produto in produtos)
        //    {
        //        if (FiltrarPorId(valor, produto))
        //        {
        //            retorno.Add(produto);
        //        }
        //    }

        //    return retorno;
        //}

        //// 1o.
        //public List<Produto> FiltrarPorId(List<Produto> produtos, int id)
        //{
        //    var retorno = new List<Produto>();

        //    foreach (var item in produtos)
        //    {
        //        if (item.Id == id)
        //        {
        //            retorno.Add(item);
        //        }
        //    }

        //    return retorno;
        //}

        //// 2o.
        //public List<Produto> FiltrarPorDescricao(List<Produto> produtos, string descricao)
        //{
        //    var retorno = new List<Produto>();

        //    foreach (var item in produtos)
        //    {
        //        if (item.Descricao.Contains(descricao))
        //        {
        //            retorno.Add(item);
        //        }
        //    }

        //    return retorno;
        //}
    }
}