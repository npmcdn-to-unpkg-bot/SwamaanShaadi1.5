using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwamaanShaadi.DomainClasses;

namespace SwamaanShaadi.DataLayer
{
    public class LookupRepository : ILookupRepository
    {
        LookupContext context = new LookupContext();

        public List<AccountStatus> GetAllAccountStatus()
        {
            return context.AllAccountStatus.OrderBy(t => t.Status).ToList();
        }

        public List<Caste> GetAllCastesForReligion(int religionId)
        {
            return context.Castes.Where(t => t.Religion.ReligionId == religionId).OrderBy(t => t.CasteName).ToList();
        }

        public List<District> GetAllDistrictsForState(int stateId)
        {
            return context.Districts.Where(t => t.HomeState.HomeStateId == stateId).OrderBy(t => t.DistrictName).ToList();
        }

        public List<Education> GetAllEducationQualifications()
        {
            return context.EducationQualifications.OrderBy(t => t.Degree).ToList();
        }

        public List<EmploymentType> GetAllEmploymentTypes()
        {
            return context.EmploymentTypes.OrderBy(t => t.Type).ToList();
        }

        public List<HomeState> GetAllHomeStates()
        {
            return context.HomeStates.OrderBy(t => t.StateName).ToList();
        }

        public List<MaritalStatus> GetAllMaritalStatus()
        {
            return context.MaritalStatuses.OrderBy(t => t.Status).ToList();
        }

        public List<Religion> GetAllReligions()
        {
            return context.Religions.OrderBy(t => t.ReligionName).ToList();
        }

        public List<Gender> GetGenders()
        {
            return context.Genders.OrderBy(t => t.Name).ToList();
        }

        public List<ProfileFor> GetProfileFor()
        {
            return context.AllProfileFor.OrderBy(t => t.Relation).ToList();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
