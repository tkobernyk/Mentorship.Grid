using Mentorship.Grid.DataAccess.Context;
using Mentorship.Grid.DataAccess.Interfaces;
using Mentorship.Grid.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Mentorship.Grid.DataAccess.Repository
{
    public class BillionaireRepository : IRepository<Billionaire>
    {
        private BillionairesDbContext dbContext;

        public BillionaireRepository()
        {
            dbContext = new BillionairesDbContext();
        }

        public int Add(Billionaire entity)
        {
            dbContext.Billionaires.Add(entity);

            return 1;
        }

        public int Delete(Billionaire entity)
        {
            dbContext.Billionaires.Remove(entity);

            return 1;
        }

        public Billionaire Get(int id)
        {
            return dbContext.Billionaires.Find(id);
        }

        public IEnumerable<Billionaire> GetAll()
        {
            return dbContext.Billionaires;
        }

        public StreamReader GetSchema(string basePath)
        {
            throw new NotImplementedException();
        }

        public Billionaire Update(int id, Billionaire entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return entity;
        }
    }
}
