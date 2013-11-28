using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IRepository<T> : IDisposable
    {
        void InsertOrUpdate(T entity);
        T Find(int id);
        void Delete(T entity);
        void Save();
    }
}
