using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Impacta.Repositorios.Ef.Designer.Testes
{
    [TestClass]
    public class VeiculoRepositorioTeste
    {
        [TestMethod]
        public void InserirTeste()
        {
            using (var contexto = new OficinaEntities())
            {
                var veiculo = new Veiculo();
                veiculo.AnoFabricacao = 2013;
                veiculo.AnoModelo = 2014;

                var cor = from c in contexto.Cor
                          where c.Descricao == "Preto"
                          select c;

                veiculo.Cor = cor.Single();
                //veiculo.Cor = contexto.Cor.Single(c => c.Descricao == "Preto");
                //veiculo.Cor = contexto.Cor.Single(c => c.Id == 1);
                //veiculo.Cor.Id = 1;
                //veiculo.Cor = new Cor {  Descricao = "Amarelo" };

                var modelo = from m in contexto.Modelo
                             where m.Id == 1
                             select m;

                veiculo.Modelo = modelo.Single();
                //veiculo.Modelo = contexto.Modelo.Single(m => m.Id == 1);
                
                veiculo.Placa = "FIB1416";

                contexto.Veiculo.Add(veiculo);
                contexto.SaveChanges();
            }
        }

        [TestMethod]
        public void SelecionarTeste()
        {
            using (var db = new OficinaEntities())
            {
                var veiculos = from v in db.Veiculo
                               where v.Cor.Descricao == "Preto"
                               select v;

                //var veiculos = db.Veiculo.Where(v => v.Cor.Descricao == "Preto");

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine("{0} - {1} - {2}", veiculo.Placa, veiculo.Modelo.Descricao, veiculo.Cor.Descricao);
                }
            }
        }

        [TestMethod]
        public void AtualizarTeste()
        {
            using (var db = new OficinaEntities())
            {
                var veiculo = SelecionarVeiculo(db, 1);

                var cor = from c in db.Cor
                          where c.Descricao == "Amarelo"
                          select c;

                veiculo.Cor = cor.Single();

                db.SaveChanges();
            }   
        }

        private static Veiculo SelecionarVeiculo(OficinaEntities db, int idVeiculo)
        {
            var veiculo = (from v in db.Veiculo
                           where v.Id == idVeiculo
                           select v).Single();
            return veiculo;
        }

        [TestMethod]
        public void ExcluirTeste()
        {
            using (var db = new OficinaEntities())
            {
                var veiculo = SelecionarVeiculo(db, 3);

                db.Veiculo.Remove(veiculo);
                db.SaveChanges();
            }
        }
    }
}