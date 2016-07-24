using SwamaanShaadi.DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DataLayer
{
    public interface IMembersContext : IDisposable
    {
        IDbSet<Member> Members { get; }
        IDbSet<AccountStatus> AllAccountStatus { get; }
        IDbSet<Religion> Religions { get; }
        IDbSet<Caste> Castes { get; }
        IDbSet<HomeState> HomeStates { get; }
        IDbSet<District> Districts { get; }
        IDbSet<Gender> Genders { get; }
        IDbSet<Education> EducationQualifications { get; }
        IDbSet<EmploymentType> EmploymentTypes { get; }
        IDbSet<MaritalStatus> MaritalStatuses { get; }
        IDbSet<ProfileFor> AllProfileFor { get; }
        IDbSet<MemberPhotograph> MemberPhotographs { get; }

        int SaveChanges();
        void SetModified(object entity);
        void SetAdd(object entity);
    }
}
