using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwamaanShaadi.DataLayer;
using SwamaanShaadi.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DataLayer.Tests
{
    [TestClass()]
    public class LookupRepositoryTests
    {
        [TestMethod()]
        public void GetAllAccountStatusTest()
        {
            using (var repo = new LookupRepository())
            {
                var accountStatus = repo.GetAllAccountStatus();
                Assert.IsTrue(accountStatus.Count > 0);
            }
        }

        [TestMethod()]
        public void GetAllCastesForReligionTest()
        {
            using (var repo = new LookupRepository())
            {
                Religion hindu = repo.GetAllReligions().Where(t => t.ReligionName == "Hindu").SingleOrDefault(); 
                var castes = repo.GetAllCastesForReligion(hindu.ReligionId);
                Assert.IsTrue(castes.Count > 0);
            }
        }

        [TestMethod()]
        public void GetAllDistrictsForStateTest()
        {
            using (var repo = new LookupRepository())
            {
                HomeState bihar = repo.GetAllHomeStates().Where(t => t.StateName == "Bihar").SingleOrDefault();
                var districts = repo.GetAllDistrictsForState(bihar.HomeStateId);
                Assert.IsTrue(districts.Count > 0);
            }
        }

        [TestMethod()]
        public void GetAllEducationQualificationsTest()
        {
            using (var repo = new LookupRepository())
            {
                var educationQualifications = repo.GetAllEducationQualifications();
                Assert.IsTrue(educationQualifications.Count > 0);
            }
        }

        [TestMethod()]
        public void GetAllEmploymentTypesTest()
        {
            using (var repo = new LookupRepository())
            {
                var employmentTypes = repo.GetAllEmploymentTypes();
                Assert.IsTrue(employmentTypes.Count > 0);
            }
        }

        [TestMethod()]
        public void GetAllHomeStatesTest()
        {
            using (var repo = new LookupRepository())
            {
                var homeStates = repo.GetAllHomeStates();
                Assert.IsTrue(homeStates.Count > 0);
            }
        }

        [TestMethod()]
        public void GetAllMaritalStatusTest()
        {
            using (var repo = new LookupRepository())
            {
                var maritalStatuses = repo.GetAllMaritalStatus();
                Assert.IsTrue(maritalStatuses.Count > 0);
            }
        }

        [TestMethod()]
        public void GetAllReligionsTest()
        {
            using (var repo = new LookupRepository())
            {
                var religions = repo.GetAllReligions();
                Assert.IsTrue(religions.Count > 0);
            }
        }

        [TestMethod()]
        public void GetGendersTest()
        {
            using (var repo = new LookupRepository())
            {
                var genders = repo.GetGenders();
                Assert.IsTrue(genders.Count > 0);
            }
        }

        [TestMethod()]
        public void GetProfileForTest()
        {
            using (var repo = new LookupRepository())
            {
                var profileFor = repo.GetProfileFor();
                Assert.IsTrue(profileFor.Count > 0);
            }
        }
    }
}