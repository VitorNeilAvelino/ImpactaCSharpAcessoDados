using Impacta.Dominio;

namespace Impacta.Repositorios.Ef.CodeFirst
{
    public class ServicoRepositorio : BaseRepositorio<Servico>,  IServicoRepositorio
    {
        private OficinaDbContext _contexto;

        public ServicoRepositorio(OficinaDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }
        //public void Inserir(Servico servico)
        //{
        //    using (var db = new OficinaDbContext())
        //    {
        //        db.Servicos.Add(servico);
        //        db.SaveChanges();
        //    }
        //}

        //public Servico Selecionar(int servicoId)
        //{
        //    using (var db = new OficinaDbContext())
        //    {
        //        return db.Servicos.SingleOrDefault(s => s.Id == servicoId);
        //    }
        //}

        //public void Atualizar(Servico servico)
        //{
        //    using (var db = new OficinaDbContext())
        //    {
        //        db.Servicos.Attach(servico);
        //        db.Entry(servico).State = System.Data.EntityState.Modified;
        //        db.SaveChanges();
        //    }
        //}

        //public void Excluir(int servicoId)
        //{
        //    var servico = Selecionar(servicoId);

        //    using (var db = new OficinaDbContext())
        //    {
        //        db.Servicos.Remove(servico);
        //        db.SaveChanges();
        //    }
        //}
    }
}