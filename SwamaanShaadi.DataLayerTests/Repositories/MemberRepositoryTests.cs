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
    public class MemberRepositoryTests
    {
        [TestMethod()]
        public void FindMemberTest()
        {
            using (var repo = new MemberRepository())
            {
                foreach (var member in repo.AllIncluding(m=>m.AccountStatus).ToList())
                {
                    Console.WriteLine(member.FirstName + " " + member.AccountStatus.Status);
                }
            }
        }

        [TestMethod()]
        public void RegisterNewMemberTest()
        {
            Random r = new Random();
            var number = r.Next(1, 100000);

            using (var repo = new MemberRepository())
            {
                //var district = repo.All.Where(d => d.District.DistrictName == "Madhubani").FirstOrDefault();

                Member member = new Member {
                    FirstName = "Navendu " + number,
                    LastName = "Kumar",
                    MobileNumber = 9802293243,
                    UserName = "9802293243",
                    ClientIPAddress = "1.2.3.4",
                    DistrictId = 2,
                    State = State.Added
                };

                repo.InsertOrUpdate(member);
                repo.Save();
            }

            using (var repo = new MemberRepository())
            {
                var member = repo.All.Where(m => m.FirstName == "Navendu " + number).ToList();
                Assert.AreEqual(member.Count, 1);
            }

            using (var repo = new MemberRepository())
            {
                var member = repo.All.Where(m => m.FirstName == "Navendu " + number).FirstOrDefault();
                repo.Delete(member.MemberId);
                repo.Save();
            }
        }
    }
}