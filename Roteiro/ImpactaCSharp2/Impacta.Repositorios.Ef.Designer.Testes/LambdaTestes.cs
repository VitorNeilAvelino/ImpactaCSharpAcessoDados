using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Impacta.Repositorios.Ef.Designer.Testes
{
    [TestClass]
    public class LambdaTestes
    {
        private List<Produto> _produtos;
        //public delegate bool Filtro(Produto produto, object valor);
        public delegate bool Filtro<T>(Produto produto, T valor);

        [TestInitialize]
        public void Inicializar()
        {
            _produtos = new List<Produto>();

            _produtos.Add(new Produto { Id = 1, Descricao = "Borracha" });
            _produtos.Add(new Produto { Id = 2, Descricao = "Lápis" });
            _produtos.Add(new Produto { Id = 3, Descricao = "Caneta" });
            _produtos.Add(new Produto { Id = 4, Descricao = "Apagador" });
        }

        // 5o.
        [TestMethod]
        public void FiltrarProduto()
        {
            //var produtosPorId = FiltrarPorId(_produtos, 2);
            //var produtosPorDescricao = FiltrarPorDescricao(_produtos, "c");

            var produtosPorId = Filtrar(_produtos, 2, FiltrarPorId);
            var produtosPorDescricao = Filtrar(_produtos, "e", FiltrarPorDescricao);

            foreach (var produto in produtosPorDescricao)
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