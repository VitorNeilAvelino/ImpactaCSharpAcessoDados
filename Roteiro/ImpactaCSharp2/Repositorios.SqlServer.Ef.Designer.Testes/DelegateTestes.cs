using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repositorios.SqlServer.Ef.Designer.Testes
{
    public delegate Decimal EfetuarOperacao(decimal valor1, decimal valor2);

    [TestClass]
    public class DelegateTestes
    {
        //public delegate Decimal EfetuarOperacao(decimal valor1, decimal valor2);

        //[TestMethod]
        //public void DelegateNaMesmaClasse()
        //{
        //    EfetuarOperacao operacao = Somar;

        //    Console.WriteLine(operacao(1, 2));
        //}

        //public decimal Somar(decimal x, decimal y)
        //{
        //    return x + y;
        //}

        [TestMethod]
        public void DelegateComoParametro()
        {
            var operacao = new Calculadora().DefinirOperacao();

            Console.WriteLine(operacao(1, 2));
        }

        [TestMethod]
        public void MetodoAnonimoTeste()
        {
            EfetuarOperacao operacao = delegate(decimal x, decimal y)
            {
                return x / y;
            };

            Console.WriteLine(operacao(1, 2));
        }

        [TestMethod]
        public void ExpressaoLambdaTeste()
        {
            EfetuarOperacao operacao = (x, y) => x * y;

            //EfetuarOperacao operacao = (x, y) =>
            //{
            //    var w = x * y;
            //    return w + 3;
            //};

            Console.WriteLine(operacao(1, 2));
        }
    }

    public class Calculadora
    {
        private TipoOperacao TipoOperacao { get; set; }

        private static decimal Somar(decimal x, decimal y)
        {
            return x + y;
        }

        private static decimal Subtrair(decimal x, decimal y)
        {
            return x - y;
        }

        public EfetuarOperacao DefinirOperacao()
        {
            TipoOperacao = Testes.TipoOperacao.Soma;

            switch (TipoOperacao)
            {
                case TipoOperacao.Soma:
                    return Somar;
                case TipoOperacao.Subtracao:
                    return Subtrair;
            }

            throw new Exception();
        }
    }

    public enum TipoOperacao
    {
        Soma,
        Subtracao
    }
}