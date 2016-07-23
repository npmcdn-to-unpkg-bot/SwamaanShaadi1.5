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
    public class MaritalStatusMap : EntityTypeConfiguration<MaritalStatus>
    {
        public MaritalStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.MaritalStatusId);

            // Properties
            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaritalStatus");
            this.Property(t => t.MaritalStatusId).HasColumnName("MaritalStatusId");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
