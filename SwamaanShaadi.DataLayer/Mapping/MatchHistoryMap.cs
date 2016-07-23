using SwamaanShaadi.DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DataLayer
{
    public class MatchHistoryMap : EntityTypeConfiguration<MatchHistory>
    {
        public MatchHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.MatchHistoryId);

            // Properties
            // Table & Column Mappings
            this.ToTable("MatchHistory");
            this.Property(t => t.MatchHistoryId).HasColumnName("MatchHistoryId");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.MatchID).HasColumnName("MatchID");
            this.Property(t => t.EmailAlertSentOn).HasColumnName("EmailAlertSentOn");
            this.Property(t => t.MobileAlertSentOn).HasColumnName("MobileAlertSentOn");
            this.Property(t => t.MatchedBySystemOn).HasColumnName("MatchedBySystemOn");

            // Relationships
            this.HasRequired(t => t.Member)
                .WithMany(t => t.MatchHistory)
                .HasForeignKey(d => d.MemberID);
            
        }
    }
}
