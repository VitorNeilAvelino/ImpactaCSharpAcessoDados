using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Repositorios.Ef.Designer
{
    class VeiculoRepositorio
    {
        public void InserirTeste()
        {
            var db = new OficinaEntities();

            using (OficinaEntities contexto = new OficinaEntities())
            {
                var veiculo = new Veiculo();
                veiculo.AnoFabricacao = 2013;
                veiculo.AnoModelo = 2014;
                veiculo.Cor = new Cor();
            }
        }
    }
}
