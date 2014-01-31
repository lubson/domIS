using Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace DataLayer
{
    public class UcastnikRepository : Repository<Ucastnik>, IUcastnikRepository
    {
        public UcastnikRepository(DbContext context) : base(context) { }
        
        public IQueryable<Ucastnik> GetUcastnikByFullName(string Jmeno)
        {
            throw new NotImplementedException();
        }
    }
}
