using Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    public class UcastnikConfig : EntityTypeConfiguration<Ucastnik>
    {
        public UcastnikConfig()
        {
            this.ToTable("Ucastnik");
            this.Property(u => u.Prijmeni)
                .HasMaxLength(35)
                .IsRequired();
            this.Property(u => u.DateCreated)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed); //Date has to be generated in sql.
        }
    }
}
