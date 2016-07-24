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
    public class PartnerDistrictMap : EntityTypeConfiguration<PartnerDistrict>
    {
        public PartnerDistrictMap()
        {
            HasKey(c => c.PartnerDistrictId);

            ToTable("PartnerDistrict");
            Property(c => c.PartnerDistrictId).HasColumnName("PartnerDistrictId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.MemberId).HasColumnName("MemberId").IsRequired();
            Property(c => c.DistrictId).HasColumnName("DistrictId");

            this.Ignore(t => t.State);
        }
    }
}
