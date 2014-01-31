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
        public Context() : base("name=db") { }
        
        public DbSet<Ucastnik> Ucastnici { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UcastnikConfig());
            
            //Ciselniky
            modelBuilder.Configurations.Add(new CNarodnostConfig());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
