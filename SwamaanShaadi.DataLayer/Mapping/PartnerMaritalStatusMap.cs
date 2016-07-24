using SwamaanShaadi.DomainClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DataLayer.Mapping
{
    public class PartnerMaritalStatusMap : EntityTypeConfiguration<PartnerMaritalStatus>
    {
        public PartnerMaritalStatusMap()
        {
            HasKey(c => c.PartnerMaritalStatusId);

            ToTable("PartnerMaritalStatus");
            Property(c => c.PartnerMaritalStatusId).HasColumnName("PartnerMaritalStatusId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.MemberId).HasColumnName("MemberId").IsRequired();
            Property(c => c.MaritalStatusId).HasColumnName("MaritalStatusId");

            this.Ignore(t => t.State);
        }
    }
}
