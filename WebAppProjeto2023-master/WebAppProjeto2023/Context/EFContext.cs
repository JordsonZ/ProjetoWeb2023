using Modelo.Cadastros;
using Modelo.Tabelas;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebAppProjeto2023.Migrations;

namespace WebAppProjeto2023.Models
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS")
        {
            //Database.SetInitializer<EFContext>(
            //new DropCreateDatabaseIfModelChanges<EFContext>());
            Database.SetInitializer<EFContext>(new
            MigrateDatabaseToLatestVersion<EFContext, Configuration>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

    }
}