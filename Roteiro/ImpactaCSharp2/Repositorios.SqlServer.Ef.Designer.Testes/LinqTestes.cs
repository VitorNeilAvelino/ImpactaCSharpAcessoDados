using System;
using System.Linq;
using Impacta.Infra.Repositorios.SqlServer.Ef.Designer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repositorios.SqlServer.Ef.Designer.Testes
{
    [TestClass]
    public class LinqTestes
    {
        private readonly OficinaEntities _contexto = new OficinaEntities();

        [TestMethod]
        public void OrderByTeste()
        {
            var lista = from veiculo in _contexto.Veiculo
                        //orderby veiculo.AnoModelo descending, veiculo.Modelo.Descricao
                        orderby veiculo.AnoModelo
                        select veiculo;

            foreach (var veiculo in lista)
            {
                Console.WriteLine("{0} - {1}", veiculo.Modelo.Descricao, veiculo.AnoModelo);
            }
        }

        [TestMethod]
        public void CountTeste()
        {
            var sql = @"SELECT        COUNT(Id) AS Total, AnoModelo
                        FROM            Veiculo
                        GROUP BY AnoModelo";

            var lista = from veiculo in _contexto.Veiculo
                        //group veiculo by new { veiculo.AnoModelo, veiculo.AnoFabricacao }
                        group veiculo by veiculo.AnoModelo
                            into grupo
                            //where grupo.Count() > 1
                            select new
                                       {
                                           //AnoFabricacao = grupo.Key.AnoFabricacao,
                                           //AnoModelo = grupo.Key.AnoModelo,
                                           AnoModelo = grupo.Key,
                                           Total = grupo.Count()
                                       };

            foreach (var item in lista)
            {
                Console.WriteLine("{0} - {1}", item.Total, item.AnoModelo);
            }
        }

        [TestMethod]
        public void InnerJoinTeste()
        {
            //Página 230 - join com listas

            var sql = @"SELECT        Vei.Id, Vei.Modelo_Id, Vei.Cor_Id, Vei.Placa, Vei.AnoFabricacao, Vei.AnoModelo, Mod.Id AS [Modelo.Id], Mod.Descricao
                        FROM            Veiculo AS Vei INNER JOIN Modelo AS Mod ON Vei.Modelo_Id = Mod.Id";

            var lista = from veiculo in _contexto.Veiculo
                        join modelo in _contexto.Modelo on veiculo.Modelo_Id equals modelo.Id
                        //orderby veiculo.AnoModelo
                        select new
                               {
                                   Modelo = modelo.Descricao,
                                   AnoModelo = veiculo.AnoModelo
                               };

            foreach (var item in lista)
            {
                Console.WriteLine("{0} - {1}", item.Modelo, item.AnoModelo);
            }
        }

        [TestMethod]
        public void LeftJoinTeste()
        {
            var sql = @"SELECT        Vei.Placa, Mod.Descricao
                        FROM            Veiculo AS Vei LEFT OUTER JOIN
                        Modelo AS Mod ON Vei.Modelo_Id = Mod.Id AND Mod.Id = 2";

            var lista = from veiculo in _contexto.Veiculo
                        join modelo in _contexto.Modelo on new { Chave1 = veiculo.Modelo_Id, Chave2 = veiculo.Modelo_Id } equals
                            new { Chave1 = modelo.Id, Chave2 = 2 }
                            into modelos
                        from modeloNoJoin in modelos.DefaultIfEmpty()
                        select new { Placa = veiculo.Placa, Modelo = (modeloNoJoin == null ? string.Empty : modeloNoJoin.Descricao) };

            foreach (var item in lista)
            {
                Console.WriteLine("{0} - {1}", item.Placa, item.Modelo);
            }
        }

        [TestMethod]
        public void LikeTeste()
        {
            var lista = from modelo in _contexto.Modelo
                        where modelo.Descricao.Contains("c")
                        orderby modelo.Descricao
                        select modelo;

            foreach (var modelo in lista)
            {
                Console.WriteLine(modelo.Descricao);
            }
        }

        [TestMethod]
        public void MinTeste()
        {
            // Página 35

            var sql = @"SELECT        MIN(DataNascimento) AS MenorData
                        FROM            Cliente";

            var clienteMaisVelho = (from cliente in _contexto.Cliente
                                    orderby cliente.DataNascimento
                                    select cliente).FirstOrDefault();

            if (clienteMaisVelho != null)
            {
                Console.WriteLine("{0} - {1}", clienteMaisVelho.Nome, clienteMaisVelho.DataNascimento);
            }
        }

        [TestMethod]
        public void SumTeste()
        {
            var sql = @"SELECT SUM(valor) FROM Servico WHERE DataInicio >= '2013-10-01' AND DataFim < = '2013-11-01'";

            var mediaDoMes = (from servico in _contexto.Servico
                             where servico.DataInicio >= new DateTime(2013, 10, 01) && servico.DataFim < new DateTime(2013, 11, 01)
                             select servico.Valor).Sum();

            Console.WriteLine(mediaDoMes);
        }
    }
}