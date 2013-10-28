using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Impacta.Infra.Repositorios.SqlServer.Ef.Designer;

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
