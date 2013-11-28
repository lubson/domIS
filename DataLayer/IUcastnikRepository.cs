using System;
using Model;

namespace DataLayer
{
    public interface IUcastnikRepository
    {
        void InsertOrUpdate(Ucastnik ucastnik);
        Ucastnik Find(int id);
        void Delete(Ucastnik ucastnik);
    }
}
