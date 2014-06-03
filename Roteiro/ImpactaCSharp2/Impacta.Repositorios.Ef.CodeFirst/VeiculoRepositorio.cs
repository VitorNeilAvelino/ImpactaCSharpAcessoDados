using Impacta.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Impacta.Repositorios.Ef.CodeFirst
{
    public class VeiculoRepositorio : BaseRepositorio<Veiculo>, IVeiculoRepositorio
    {
        private OficinaDbContext _contexto;

        public VeiculoRepositorio(OficinaDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public Veiculo PesquisarPorPlaca(string placa)
        {
            return _contexto.Veiculos.SingleOrDefault(v => v.Placa == placa);
        }
    }
}