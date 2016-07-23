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
    public class EmploymentTypeMap : EntityTypeConfiguration<EmploymentType>
    {
        public EmploymentTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmploymentTypeId);

            // Properties
            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EmploymentType");
            this.Property(t => t.EmploymentTypeId).HasColumnName("EmploymentTypeId");
            this.Property(t => t.Type).HasColumnName("Type");
        }
    }
}
