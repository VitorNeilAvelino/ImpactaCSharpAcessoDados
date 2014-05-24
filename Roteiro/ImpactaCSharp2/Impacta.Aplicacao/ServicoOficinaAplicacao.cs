using Impacta.Repositorios.Ef.Designer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impacta.Aplicacao
{
    public class ServicoOficinaAplicacao
    {
        OficinaEntities _contexto = new OficinaEntities();

        public Veiculo SelecionarPorPlaca(string placa)
        {
            return _contexto.Veiculo.Where(x => x.Placa == placa).FirstOrDefault();
        }
    }
}
