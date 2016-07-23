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
    public class EducationMap : EntityTypeConfiguration<Education>
    {
        public EducationMap()
        {
            // Primary Key
            this.HasKey(t => t.EducationId);

            // Properties
            this.Property(t => t.Degree)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Education");
            this.Property(t => t.EducationId).HasColumnName("EducationId");
            this.Property(t => t.Degree).HasColumnName("Degree");
        }
    }
}
