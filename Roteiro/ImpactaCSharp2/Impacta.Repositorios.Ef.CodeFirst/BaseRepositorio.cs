using System.Data;
using System.Linq;
using Impacta.Dominio;

namespace Impacta.Repositorios.Ef.CodeFirst
{
    public class BaseRepositorio<T> where T : class, IEntidade
    {
        private readonly OficinaDbContext _contexto;// = new OficinaDbContext();

        public BaseRepositorio()
        {

        }

        public BaseRepositorio(OficinaDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Inserir(T entidade)
        {
            //using (var db = new OficinaDbContext())
            //{
            _contexto.Set<T>().Add(entidade);
            //_contexto.SaveChanges();
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