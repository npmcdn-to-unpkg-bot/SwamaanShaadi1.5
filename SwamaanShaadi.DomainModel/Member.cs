using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DomainClasses
{
    public class Member
    {
        public Member()
        {
            MatchHistory = new List<MatchHistory>();
            MemberPhotographs = new List<MemberPhotograph>();
        }

        public int MemberId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public long MobileNumber { get; set; }
        public string EmailId { get; set; }
        public int? ProfileForId { get; set; }
        public int? GenderId { get; set; }
        public int? ReligionId { get; set; }
        public int? CasteId { get; set; }
        public int? HomeStateId { get; set; }
        public int? DistrictId { get; set; }
        public string Address { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? EducationId { get; set; }
        public int? EmploymentTypeId { get; set; }
        public string CompanyName { get; set; }
        public string WorkLocationAddress { get; set; }
        public int? PartnerMinAge { get; set; }
        public int? PartnerMaxAge { get; set; }
        public int? MobileAlertActive { get; set; }
        public int? EmailAlertActive { get; set; }
        public int? AccountStatusId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool? IsVerified { get; set; }
        public string VerifiedBy { get; set; }
        public DateTime? VerifiedOn { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public string ClientIPAddress { get; set; }

        public virtual AccountStatus AccountStatus { get; set; }
        public virtual Caste Caste { get; set; }
        public virtual District District { get; set; }
        public virtual Education Education { get; set; }
        public virtual EmploymentType EmploymentType { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public virtual ProfileFor ProfileFor { get; set; }
        public virtual Religion Religion { get; set; }
        public virtual HomeState HomeState { get; set; }

        public virtual List<MatchHistory> MatchHistory { get; set; }
        public virtual List<MemberPhotograph> MemberPhotographs { get; set; }
    
    }
}
