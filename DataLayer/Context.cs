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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*Ucastnik*/
            modelBuilder.Entity<Ucastnik>().ToTable("Ucastnik");
            modelBuilder.Entity<Ucastnik>().Property(u => u.Prijmeni)
                .HasMaxLength(35)
                .IsRequired();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
