using System;
using System.Collections.Generic;

namespace Telefonica.Business
{
    public interface IRepository<T> : IDisposable
    {
        IEnumerable<T> GetAll();
        T Get(Guid num);
        void Insert(T obj);
        void Delete(Guid obj);
        void Update(T telefono);
        void Save();
    }
}