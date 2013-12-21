using Model;
using System.Data.Entity.ModelConfiguration;

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
        }
    }
}
