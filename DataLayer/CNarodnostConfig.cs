using Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    public class CNarodnostConfig : EntityTypeConfiguration<CNarodnost>
    {
        public CNarodnostConfig()
        {
            this.ToTable("CNarodnost");
            this.Property(c => c.Kod)
                .IsRequired()
                .HasMaxLength(3)                ;
            this.Property(c => c.Nazev)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
