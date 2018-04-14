using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using Mentorship.Grid.DataAccess.Interfaces;

namespace Mentorship.Grid.Wcf.Server.Interfaces
{
    [ServiceContract]
    public interface IContract<T> where T : IEntity
    {
        [OperationContract]
        T Get(int id);
        [OperationContract]
        StreamReader GetSchema(string basePath);
        [OperationContract]
        IEnumerable<T> GetAll();
        [OperationContract]
        int Add(T entity);
        [OperationContract]
        T Update(int id, T entity);
        [OperationContract]
        int Delete(T entity);
    }
}
