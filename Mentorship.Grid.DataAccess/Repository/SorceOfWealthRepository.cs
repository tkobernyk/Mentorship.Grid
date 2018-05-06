using Mentorship.Grid.DataAccess.Context;
using Mentorship.Grid.DataAccess.Interfaces;
using Mentorship.Grid.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentorship.Grid.DataAccess.Repository
{
    public class SorceOfWealthRepository : IRepository<SourceOfWealth>
    {
        private BillionairesDbContext dbContext;

        public SorceOfWealthRepository()
        {
            dbContext = new BillionairesDbContext();
        }

        public int Add(SourceOfWealth entity)
        {
            dbContext.SourcesOfWealth.Add(entity);

            return 1;
        }

        public int Delete(SourceOfWealth entity)
        {
            dbContext.SourcesOfWealth.Remove(entity);

            return 1;
        }

        public SourceOfWealth Get(int id)
        {
            return dbContext.SourcesOfWealth.Find(id);
        }

        public IEnumerable<SourceOfWealth> GetAll()
        {
            return dbContext.SourcesOfWealth;
        }

        public StreamReader GetSchema(string basePath)
        {
            throw new NotImplementedException();
        }

        public SourceOfWealth Update(int id, SourceOfWealth entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return entity;
        }
    }
}
