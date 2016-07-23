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
    public class AccountStatusMap : EntityTypeConfiguration<AccountStatus>
    {
        public AccountStatusMap()
        {
            // Primary Key
            HasKey(p => p.AccountStatusId);

            //Properties
            Property(t => t.Status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);


            // Table & Column Mappings
            this.ToTable("AccountStatus");
            this.Property(t => t.AccountStatusId).HasColumnName("AccountStatusId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
