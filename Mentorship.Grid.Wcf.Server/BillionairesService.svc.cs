using System;
using System.Collections.Generic;
using System.IO;
using Mentorship.Grid.DataAccess.Models;
using Mentorship.Grid.Wcf.Server.Interfaces;

namespace Mentorship.Grid.Wcf.Server
{
    public class BillionairesService : IContract<Billionaire>
    {
        public Billionaire Get(int id)
        {
            throw new NotImplementedException();
        }

        public StreamReader GetSchema(string basePath)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Billionaire> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Add(Billionaire entity)
        {
            throw new NotImplementedException();
        }

        public Billionaire Update(int id, Billionaire entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(Billionaire entity)
        {
            throw new NotImplementedException();
        }
    }
}
