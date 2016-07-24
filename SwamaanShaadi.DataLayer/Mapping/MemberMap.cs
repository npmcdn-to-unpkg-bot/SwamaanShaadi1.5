using SwamaanShaadi.DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DataLayer
{
    public class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            // Primary Key
            this.HasKey(t => t.MemberId);
            
            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(100);

            this.Property(t => t.FirstName)
                .HasMaxLength(100);

            this.Property(t => t.MiddleName)
                .HasMaxLength(100);

            this.Property(t => t.LastName)
                .HasMaxLength(100);

            this.Property(t => t.FatherName)
                .HasMaxLength(500);

            this.Property(t => t.EmailId)
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(500);

            this.Property(t => t.CompanyName)
                .HasMaxLength(100);

            this.Property(t => t.WorkLocationAddress)
                .HasMaxLength(500);

            this.Property(t => t.VerifiedBy)
                .HasMaxLength(100);

            this.Property(t => t.ClientIPAddress)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Members");
            this.Property(t => t.MemberId).HasColumnName("MemberId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.FatherName).HasColumnName("FatherName");
            this.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(t => t.MobileNumber).HasColumnName("MobileNumber");
            this.Property(t => t.EmailId).HasColumnName("EmailId");
            this.Property(t => t.ProfileForId).HasColumnName("ProfileForId");
            this.Property(t => t.GenderId).HasColumnName("GenderId");
            this.Property(t => t.ReligionId).HasColumnName("ReligionId");
            this.Property(t => t.CasteId).HasColumnName("CasteId");
            this.Property(t => t.HomeStateId).HasColumnName("StateId");
            this.Property(t => t.DistrictId).HasColumnName("DistrictId");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.MaritalStatusId).HasColumnName("MaritalStatusId");
            this.Property(t => t.EducationId).HasColumnName("EducationId");
            this.Property(t => t.EmploymentTypeId).HasColumnName("EmploymentTypeId");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.WorkLocationAddress).HasColumnName("WorkLocationAddress");
            this.Property(t => t.PartnerMinAge).HasColumnName("PartnerMinAge");
            this.Property(t => t.PartnerMaxAge).HasColumnName("PartnerMaxAge");
            this.Property(t => t.MobileAlertActive).HasColumnName("MobileAlertActive");
            this.Property(t => t.EmailAlertActive).HasColumnName("EmailAlertActive");
            this.Property(t => t.AccountStatusId).HasColumnName("AccountStatusId");
            this.Property(t => t.RegistrationDate).HasColumnName("RegistrationDate");
            this.Property(t => t.IsVerified).HasColumnName("IsVerified");
            this.Property(t => t.VerifiedBy).HasColumnName("VerifiedBy");
            this.Property(t => t.VerifiedOn).HasColumnName("VerifiedOn");
            this.Property(t => t.LastUpdatedTime).HasColumnName("LastUpdatedTime");
            this.Property(t => t.ClientIPAddress).HasColumnName("ClientIPAddress");

            // Relationships
            this.HasOptional(t => t.AccountStatus);
            this.HasOptional(t => t.Education);
            this.HasOptional(t => t.EmploymentType);
            this.HasOptional(t => t.Gender);
            this.HasOptional(t => t.MaritalStatus);
            this.HasOptional(t => t.ProfileFor);
            this.HasOptional(t => t.Religion);
            this.HasOptional(t => t.Caste);
            this.HasOptional(t => t.HomeState);
            this.HasOptional(t => t.District);


            this.Ignore(t => t.State);
        }
    }
}
