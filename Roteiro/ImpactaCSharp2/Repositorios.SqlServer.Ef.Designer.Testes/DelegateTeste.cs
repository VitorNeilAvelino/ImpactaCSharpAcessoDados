using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repositorios.SqlServer.Ef.Designer.Testes
{
    public delegate Decimal EfetuarOperacao(decimal valor1, decimal valor2);

    [TestClass]
    public class DelegateTeste
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
    }

    public class Calculadora
    {
        private TipoOperacao TipoOperacao { get; set; }

        private decimal Somar(decimal x, decimal y)
        {
            return x + y;
        }

        private decimal Subtrair(decimal x, decimal y)
        {
            return x - y;
        }

        public Testes.EfetuarOperacao DefinirOperacao()
        {
            TipoOperacao = Testes.TipoOperacao.Soma;

            switch (TipoOperacao)
            {
                case TipoOperacao.Soma:
                    return new Testes.EfetuarOperacao(Somar);
                    break;
                case TipoOperacao.Subtracao:
                    return new Testes.EfetuarOperacao(Subtrair);
                    break;
            }
            throw new Exception();
        }
    }

    public enum TipoOperacao
    {
        Soma,
        Subtracao
    }

        //public class CalculadoraAplicacao
    //{
    //    public delegate Decimal EfetuarOperacao(decimal valor1, decimal valor2);
    //}
}
