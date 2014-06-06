using Impacta.Dominio;
using System;

namespace Impacta.Repositorios.Ef.CodeFirst
{
    public class OficinaUnityOfWork : IDisposable
    {
        private OficinaDbContext _contexto = new OficinaDbContext();
        private VeiculoRepositorio _veiculoRepositorio;
        private ServicoRepositorio _servicoRepositorio;
        private BaseRepositorio<Cor> _corRepositorio;

        public VeiculoRepositorio VeiculoRepositorio { get { return _veiculoRepositorio ?? (_veiculoRepositorio = new VeiculoRepositorio(_contexto)); } }
        public ServicoRepositorio ServicoRepositorio { get { return _servicoRepositorio ?? (_servicoRepositorio = new ServicoRepositorio(_contexto)); } }
        public BaseRepositorio<Cor> CorRepositorio { get { return _corRepositorio ?? (_corRepositorio = new BaseRepositorio<Cor>(_contexto)); } }

        public void Salvar()
        {
            _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}