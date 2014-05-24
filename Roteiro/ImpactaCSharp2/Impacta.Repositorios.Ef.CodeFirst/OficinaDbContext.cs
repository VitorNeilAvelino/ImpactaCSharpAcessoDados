using Impacta.Dominio;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Impacta.Repositorios.Ef.CodeFirst
{
    public class OficinaDbContext : DbContext
    {
        public OficinaDbContext()
            : base("oficinaConnectionString")
        {
            Database.SetInitializer<OficinaDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}