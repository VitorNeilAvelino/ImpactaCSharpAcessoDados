using Impacta.Dominio;
using System.Linq;

namespace Impacta.Repositorios.Ef.CodeFirst
{
    public class VeiculoRepositorio : BaseRepositorio<Veiculo>, IVeiculoRepositorio
    {
        private readonly OficinaDbContext _contexto = new OficinaDbContext();

        public VeiculoRepositorio()
        {
            
        }

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