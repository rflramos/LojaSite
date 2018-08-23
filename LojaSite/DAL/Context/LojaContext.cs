using LojaSite.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;



namespace LojaSite.DAL.Context
{
    public class LojaContext: System.Data.Entity.DbContext
    {
        public LojaContext() : base("name=OracleConnectionString")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("RM79470");

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Mercado> Mercado { get; set; }

    }
}