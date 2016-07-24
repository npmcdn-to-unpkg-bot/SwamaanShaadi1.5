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
    public class ProfileForMap : EntityTypeConfiguration<ProfileFor>
    {
        public ProfileForMap()
        {
            // Primary Key
            this.HasKey(t => t.ProfileForId);

            // Properties
            this.Property(t => t.Relation)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProfileFor");
            this.Property(t => t.ProfileForId).HasColumnName("ProfileForId");
            this.Property(t => t.Relation).HasColumnName("Relation");

            this.Ignore(t => t.State);
        }
    }
}
