using System.Data;
using System.Linq;
using Impacta.Dominio;
using System;

namespace Impacta.Repositorios.Ef.CodeFirst
{
    public class BaseRepositorio<T> where T : class, IEntidade
    {
        private OficinaDbContext _contexto;

        public BaseRepositorio(OficinaDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Inserir(T entidade)
        {
            //using (var db = new OficinaDbContext())
            //{
                _contexto.Set<T>().Add(entidade);
                //db.Servicos.Add(entidade);
            //    db.SaveChanges();
            //}
        }

        public T Selecionar(int entidadeId)
        {
            //using (var db = new OficinaDbContext())
            //{
            return _contexto.Set<T>().SingleOrDefault(x => x.Id == entidadeId);
            //}
        }

        public void Atualizar(T entidade)
        {
            //using (var db = new OficinaDbContext())
            //{
            _contexto.Set<T>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;
                //db.SaveChanges();
            //}
        }

        public void Excluir(int entidadeId)
        {
            var entidade = Selecionar(entidadeId);

            //using (var db = new OficinaDbContext())
            //{
                //db.Servicos.Remove(servico);
            _contexto.Set<T>().Remove(entidade);
                //db.SaveChanges();
            //}
        }
    }
}