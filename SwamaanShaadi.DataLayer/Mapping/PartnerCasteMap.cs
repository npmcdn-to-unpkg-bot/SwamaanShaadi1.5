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
    public class PartnerCasteMap : EntityTypeConfiguration<PartnerCaste>
    {
        public PartnerCasteMap()
        {
            HasKey(c => c.PartnerCasteId);

            ToTable("PartnerCaste");
            Property(c => c.PartnerCasteId).HasColumnName("PartnerCasteId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.MemberId).HasColumnName("MemberId").IsRequired();
            Property(c => c.CasteId).HasColumnName("CasteId");

            this.Ignore(t => t.State);
        }
    }
}
