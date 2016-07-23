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
    public class AlertSettingMap : EntityTypeConfiguration<AlertSetting>
    {
        public AlertSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountSettingId);

            // Properties
            this.Property(t => t.NoOfMatchesToSendInEachRun)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SMSStatusCheckWaitTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AlertSettings");
            this.Property(t => t.NoOfMatchesToSendInEachRun).HasColumnName("NoOfMatchesToSendInEachRun");
            this.Property(t => t.SMSStatusCheckWaitTime).HasColumnName("SMSStatusCheckWaitTime");
        }
    }
}
