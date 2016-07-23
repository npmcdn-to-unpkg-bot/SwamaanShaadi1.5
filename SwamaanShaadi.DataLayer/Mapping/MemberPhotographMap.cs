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
    public class MemberPhotographMap : EntityTypeConfiguration<MemberPhotograph>
    {
        public MemberPhotographMap()
        {
            HasKey(c => c.MemberPhotographId);

            // Properties
            this.Property(t => t.PhotographPath)
                .IsRequired()
                .HasMaxLength(1000);

            ToTable("MemberPhotograph");
            Property(c => c.MemberPhotographId).HasColumnName("MemberPhotographId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.MemberId).HasColumnName("MemberId").IsRequired();
            Property(c => c.IsProfilePhoto).HasColumnName("IsProfilePhoto");
            Property(c => c.PhotographPath).HasColumnName("PhotographPath");
        }
    }
}
