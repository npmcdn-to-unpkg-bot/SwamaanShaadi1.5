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
    public class GenderMap : EntityTypeConfiguration<Gender>
    {
        public GenderMap()
        {
            // Primary Key
            this.HasKey(t => t.GenderId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Gender");
            this.Property(t => t.GenderId).HasColumnName("GenderId");
            this.Property(t => t.Name).HasColumnName("Name");

            this.Ignore(t => t.State);
        }
    }
}
