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
    //Mapping using Fluent API
    public class DistrictMap : EntityTypeConfiguration<District>
    {
        public DistrictMap()
        {
            // Primary Key
            this.HasKey(t => t.DistrictId);

            // Properties
            this.Property(t => t.DistrictName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Districts");
            this.Property(t => t.DistrictId).HasColumnName("DistrictId");
            this.Property(t => t.DistrictName).HasColumnName("DistrictName");
            this.Property(t => t.HomeStateId).HasColumnName("StateId");

            // Relationships
            this.HasRequired(t => t.HomeState)
                .WithMany(t => t.Districts)
                .HasForeignKey(d => d.HomeStateId);

            this.Ignore(t => t.State);

        }
    }
}
