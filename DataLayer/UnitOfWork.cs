using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IDisposable
    {
        private readonly Context _context;

        internal Context Context
        {
            get { return _context; }
        }

        public UnitOfWork()
        {
            _context = new Context();
        }

        public UnitOfWork(Context context)
        {
            _context = new Context();
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
