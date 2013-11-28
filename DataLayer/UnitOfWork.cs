using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
               
        public UnitOfWork()
        {
            _context = new Context();
        }

        public UnitOfWork(Context context)
        {
            _context = context;
        }

        public Context Context()
        {
            return _context;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
