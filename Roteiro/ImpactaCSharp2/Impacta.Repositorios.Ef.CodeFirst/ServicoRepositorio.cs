using Impacta.Dominio;
using System.Linq;

namespace Impacta.Repositorios.Ef.CodeFirst
{
    public class ServicoRepositorio : IServicoRepositorio
    {
        public void Inserir(Servico servico)
        {
            using (var db = new OficinaDbContext())
            {
                db.Servicos.Add(servico);
                db.SaveChanges();
            }
        }

        public Servico Selecionar(int servicoId)
        {
            using (var db = new OficinaDbContext())
            {
                return db.Servicos.SingleOrDefault(s => s.Id == servicoId);
            }
        }

        public void Atualizar(Servico servico)
        {
            using (var db = new OficinaDbContext())
            {

            }
        }

        public void Excluir(int servicoId)
        {
            var servico = Selecionar(servicoId);

            using (var db = new OficinaDbContext())
            {
                db.Servicos.Remove(servico);
                db.SaveChanges();
            }
        }
    }
}