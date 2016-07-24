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
    public class StateMap : EntityTypeConfiguration<HomeState>
    {
        public StateMap()
        {
            // Primary Key
            this.HasKey(t => t.HomeStateId);

            // Properties
            this.Property(t => t.StateName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("States");
            this.Property(t => t.HomeStateId).HasColumnName("StateId");
            this.Property(t => t.StateName).HasColumnName("StateName");

            this.Ignore(t => t.State);
        }
    }
}
