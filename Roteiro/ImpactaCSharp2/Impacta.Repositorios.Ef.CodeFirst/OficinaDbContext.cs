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

            //modelBuilder.Entity<Servico>().Ignore(s => s.Sigla);
            //modelBuilder.Entity<Servico>().ToTable("tbServico");
            //modelBuilder.Entity<Servico>().Property(s => s.Sigla).HasColumnName("OutroNome");

        }

        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cor> Cores { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<TipoServico> TipoServicos { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Montadora> Montadoras { get; set; }
    }
}