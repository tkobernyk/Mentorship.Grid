using Mentorship.Grid.DataAccess.Interfaces;
using Mentorship.Grid.DataAccess.Models;
using System.Data.Entity;

namespace Mentorship.Grid.DataAccess.Context
{
    public class BillionairesDbContext : DbContext, IDbContextBillionaire, IDbContextSourceOfWealth
    {
        public BillionairesDbContext() : base(Properties.Settings.Default.ConnectionString)
        {
           //base.Configuration.ProxyCreationEnabled = false;
        }

        static BillionairesDbContext()
        {
            Database.SetInitializer<BillionairesDbContext>(new MyContextInitializer());
        }

        public DbSet<Billionaire> Billionaires { get; set; }

        public DbSet<SourceOfWealth> SourcesOfWealth { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Billionaire>()
                .HasMany<SourceOfWealth>(b => b.SourcesOfWealth)
                .WithMany(s => s.Billionaires);

            base.OnModelCreating(modelBuilder);
        }
    }
}
