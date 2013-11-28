using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;

namespace DataLayer
{
    public class UcastnikRepository : IUcastnikRepository
    {
        private Context Context;
        private IDbSet<Ucastnik> Ucastnici
        { 
            get
            {
                return Context.Ucastnici;
            }
        }

        public UcastnikRepository(IUnitOfWork unitOfWork)
        {
            Context = unitOfWork.Context();
        }

        public void InsertOrUpdate(Ucastnik ucastnik) {
            if (ucastnik.Id == default(int))
            {
                ucastnik.Created = DateTime.Now;
                Ucastnici.Add(ucastnik);
            }
            else {
                Context.Entry(ucastnik).State = EntityState.Modified;
            }
        }

        public Ucastnik Find(int id)
        {
            return Ucastnici.Find(id);
        }

        public void Delete(Ucastnik ucastnik)
        {
            Ucastnici.Remove(ucastnik);
        }
    }
}
