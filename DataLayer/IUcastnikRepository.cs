using System;
using Model;
using System.Linq;

namespace DataLayer
{
    public interface IUcastnikRepository : IRepository<Ucastnik>
    {
        IQueryable<Ucastnik> GetUcastnikByFullName(string Jmeno);
    }
}
