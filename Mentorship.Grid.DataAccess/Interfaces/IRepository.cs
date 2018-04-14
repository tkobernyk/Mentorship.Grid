using System.Collections.Generic;
using System.IO;

namespace Mentorship.Grid.DataAccess.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        T Get(int id);
        StreamReader GetSchema(string basePath);
        IEnumerable<T> GetAll();
        int Add(T entity);
        T Update(int id, T entity);
        int Delete(T entity);
    }
}
