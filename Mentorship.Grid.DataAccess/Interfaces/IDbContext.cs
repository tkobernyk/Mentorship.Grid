using System;
using System.Data.Entity;
using Mentorship.Grid.DataAccess.Models;

namespace Mentorship.Grid.DataAccess.Interfaces
{
    public interface IDbContextBillionaire : IDisposable
    {
        DbSet<Billionaire> Billionaires { get; set; }
        int SaveChanges();
    }
    public interface IDbContextSourceOfWealth : IDisposable
    {
        DbSet<SourceOfWealth> SourcesOfWealth { get; set; }
        int SaveChanges();
    }
}
