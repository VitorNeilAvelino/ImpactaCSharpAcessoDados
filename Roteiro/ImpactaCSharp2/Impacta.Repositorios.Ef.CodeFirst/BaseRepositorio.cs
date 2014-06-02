using System.Data;
using System.Linq;
using Impacta.Dominio;

namespace Impacta.Repositorios.Ef.CodeFirst
{
    public abstract class BaseRepositorio<T> where T : class, IEntidade
    {
        public void Inserir(T entidade)
        {
            using (var db = new OficinaDbContext())
            {
                db.Set<T>().Add(entidade);
                //db.Servicos.Add(entidade);
                db.SaveChanges();
            }
        }

        public T Selecionar(int entidadeId)
        {
            using (var db = new OficinaDbContext())
            {
                return db.Set<T>().SingleOrDefault(x => x.Id == entidadeId);
            }
        }

        public void Atualizar(T entidade)
        {
            using (var db = new OficinaDbContext())
            {
                db.Set<T>().Attach(entidade);
                db.Entry(entidade).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Excluir(int entidadeId)
        {
            var entidade = Selecionar(entidadeId);

            using (var db = new OficinaDbContext())
            {
                //db.Servicos.Remove(servico);
                db.Set<T>().Remove(entidade);
                db.SaveChanges();
            }
        }
    }
}