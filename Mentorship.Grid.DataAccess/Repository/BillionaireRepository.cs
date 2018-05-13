using Mentorship.Grid.DataAccess.Context;
using Mentorship.Grid.DataAccess.Interfaces;
using Mentorship.Grid.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Data.Entity;
using System.Linq;

namespace Mentorship.Grid.DataAccess.Repository
{
    public class BillionaireRepository : IRepository<Billionaire>, IDisposable
    {
        private BillionairesDbContext _dbContext;

        public BillionaireRepository()
        {
            _dbContext = new BillionairesDbContext();
        }

        public int Add(Billionaire entity)
        {
            _dbContext.Billionaires.Add(entity);

            return 1;
        }

        public int Delete(Billionaire entity)
        {
            _dbContext.Billionaires.Remove(entity);

            return 1;
        }

        public Billionaire Get(int id)
        {
            return _dbContext.Billionaires.Include(b => b.SourcesOfWealth).ToList().Find(b => b.Id == id);
        }

        public IEnumerable<Billionaire> GetAll()
        {
            return _dbContext.Billionaires.Include(b => b.SourcesOfWealth).ToList();
        }

        public StreamReader GetSchema(string basePath)
        {
            throw new NotImplementedException();
        }

        public Billionaire Update(int id, Billionaire entity)
        {
            _dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return entity;
        }

        #region IDisposable Support
        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }

                disposedValue = true;
            }
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
