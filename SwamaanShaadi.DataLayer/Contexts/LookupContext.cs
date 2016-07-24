using SwamaanShaadi.DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DataLayer
{
    public class LookupContext : DbContext
    {
        public LookupContext() : base("name=TestDb")
        {
            Configuration.AutoDetectChangesEnabled = false;
            Configuration.ValidateOnSaveEnabled = false;
        }

        private DbQuery<AccountStatus> _allAccountStatus;
        private DbQuery<Religion> _religions;
        private DbQuery<Caste> _castes;
        private DbQuery<HomeState> _homeStates;
        private DbQuery<District> _districts;
        private DbQuery<Gender> _genders;
        private DbQuery<Education> _educationQualifications;
        private DbQuery<EmploymentType> _employmentTypes;
        private DbQuery<MaritalStatus> _maritalStatuses;
        private DbQuery<ProfileFor> _allProfileFor;


        internal DbQuery<AccountStatus> AllAccountStatus
        {
            get
            {
                if (_allAccountStatus == null)
                {
                    _allAccountStatus = Set<AccountStatus>().AsNoTracking();
                }
                return _allAccountStatus;
            }
            set
            {
                _allAccountStatus = value;
            }
        }

        internal DbQuery<Religion> Religions
        {
            get
            {
                if (_religions == null)
                {
                    _religions = Set<Religion>().AsNoTracking();
                }
                return _religions;
            }
            set
            {
                _religions = value;
            }
        }

        internal DbQuery<Caste> Castes
        {
            get
            {
                if (_castes == null)
                {
                    _castes = Set<Caste>().AsNoTracking();
                }
                return _castes;
            }
            set
            {
                _castes = value;
            }
        }

        internal DbQuery<HomeState> HomeStates
        {
            get
            {
                if (_homeStates == null)
                {
                    _homeStates = Set<HomeState>().AsNoTracking();
                }
                return _homeStates;
            }
            set
            {
                _homeStates = value;
            }
        }

        internal DbQuery<District> Districts
        {
            get
            {
                if (_districts == null)
                {
                    _districts = Set<District>().AsNoTracking();
                }
                return _districts;
            }
            set
            {
                _districts = value;
            }
        }

        internal DbQuery<Gender> Genders
        {
            get
            {
                if (_genders == null)
                {
                    _genders = Set<Gender>().AsNoTracking();
                }
                return _genders;
            }
            set
            {
                _genders = value;
            }
        }

        internal DbQuery<Education> EducationQualifications
        {
            get
            {
                if (_educationQualifications == null)
                {
                    _educationQualifications = Set<Education>().AsNoTracking();
                }
                return _educationQualifications;
            }
            set
            {
                _educationQualifications = value;
            }
        }

        internal DbQuery<EmploymentType> EmploymentTypes
        {
            get
            {
                if (_employmentTypes == null)
                {
                    _employmentTypes = Set<EmploymentType>().AsNoTracking();
                }
                return _employmentTypes;
            }
            set
            {
                _employmentTypes = value;
            }
        }

        internal DbQuery<MaritalStatus> MaritalStatuses
        {
            get
            {
                if (_maritalStatuses == null)
                {
                    _maritalStatuses = Set<MaritalStatus>().AsNoTracking();
                }
                return _maritalStatuses;
            }
            set
            {
                _maritalStatuses = value;
            }
        }

        internal DbQuery<ProfileFor> AllProfileFor
        {
            get
            {
                if (_allProfileFor == null)
                {
                    _allProfileFor = Set<ProfileFor>().AsNoTracking();
                }
                return _allProfileFor;
            }
            set
            {
                _allProfileFor = value;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AccountStatusMap());
            modelBuilder.Configurations.Add(new ReligionMap());
            modelBuilder.Configurations.Add(new CasteMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new DistrictMap());
            modelBuilder.Configurations.Add(new GenderMap());
            modelBuilder.Configurations.Add(new EducationMap());
            modelBuilder.Configurations.Add(new EmploymentTypeMap());
            modelBuilder.Configurations.Add(new MaritalStatusMap());
            modelBuilder.Configurations.Add(new ProfileForMap());
        }
    }
}
