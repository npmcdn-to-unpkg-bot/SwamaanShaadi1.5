using SwamaanShaadi.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DataLayer
{
    public interface ILookupRepository : IDisposable
    {
        List<HomeState> GetAllHomeStates();
        List<District> GetAllDistrictsForState(int stateId);
        List<Religion> GetAllReligions();
        List<Caste> GetAllCastesForReligion(int religionId);
        List<AccountStatus> GetAllAccountStatus();
        List<Gender> GetGenders();
        List<Education> GetAllEducationQualifications();
        List<EmploymentType> GetAllEmploymentTypes();
        List<MaritalStatus> GetAllMaritalStatus();
        List<ProfileFor> GetProfileFor();
    }
}
