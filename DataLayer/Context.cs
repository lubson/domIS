using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace DataLayer
{
    public class Context : DbContext
    {
        public DbSet<Ucastnik> Ucastnici { get; set; }

        public Context() : base("name=db") {}
    }
}
