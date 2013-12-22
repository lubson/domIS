using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace DataLayer
{
    public class AppContext : DbContext
    {
        public AppContext() : base("name=db") { }
        
        public DbSet<Ucastnik> Ucastnici { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UcastnikConfig());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
