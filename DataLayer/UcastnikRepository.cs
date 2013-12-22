using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;

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
