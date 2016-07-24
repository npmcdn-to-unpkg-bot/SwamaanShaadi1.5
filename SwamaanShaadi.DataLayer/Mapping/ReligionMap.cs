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
    public class ReligionMap : EntityTypeConfiguration<Religion>
    {
        public ReligionMap()
        {
            // Primary Key
            this.HasKey(t => t.ReligionId);

            // Properties
            this.Property(t => t.ReligionName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Religions");
            this.Property(t => t.ReligionId).HasColumnName("ReligionId");
            this.Property(t => t.ReligionName).HasColumnName("ReligionName");

            this.Ignore(t => t.State);
        }
    }
}
