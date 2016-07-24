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
    public class PartnerEducationMap : EntityTypeConfiguration<PartnerEducation>
    {
        public PartnerEducationMap()
        {
            HasKey(c => c.PartnerEducationId);

            ToTable("PartnerEducation");
            Property(c => c.PartnerEducationId).HasColumnName("PartnerEducationId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.MemberId).HasColumnName("MemberId").IsRequired();
            Property(c => c.EducationId).HasColumnName("EducationId");

            this.Ignore(t => t.State);
        }
    }
}
