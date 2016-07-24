using SwamaanShaadi.DomainClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DataLayer
{
    public class CasteMap : EntityTypeConfiguration<Caste>
    {
        public CasteMap()
        {
            // Primary Key
            this.HasKey(t => t.CasteId);

            // Properties
            this.Property(t => t.CasteName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Castes");
            this.Property(t => t.CasteId).HasColumnName("CasteId");
            this.Property(t => t.CasteName).HasColumnName("CasteName");
            this.Property(t => t.ReligionId).HasColumnName("ReligionId");

            // Relationships
            this.HasRequired(t => t.Religion)
                .WithMany(t => t.Castes)
                .HasForeignKey(d => d.ReligionId);

            this.Ignore(t => t.State);

        }
    }
}
