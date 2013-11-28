using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;

namespace DataLayer
{
    public class UcastnikRepository
    {
        private Context context;
        private IDbSet<Ucastnik> ucastnici
        { 
            get
            {
                return context.Ucastnici;
            }
        }


        public UcastnikRepository(UnitOfWork unitOfWork)
        {
            context = unitOfWork.Context;
        }

        public void InsertOrUpdate(Ucastnik ucastnik) {
            if (ucastnik.Id == default(int))
            {
                ucastnici.Add(ucastnik);
            }
            else {
                context.Entry(ucastnik).State = EntityState.Modified;
            }
        }

        public Ucastnik Find(int id)
        {
            return ucastnici.Find(id);
        }

        public void Delete(Ucastnik ucastnik)
        {
            ucastnici.Remove(ucastnik);
        }
    }
}
