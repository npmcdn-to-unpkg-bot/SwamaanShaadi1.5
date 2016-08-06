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
                Member member = repo.GetMemberProfile(1);
                if (member != null)
                {
                    Console.WriteLine(member.FirstName + " " + member.LastName);
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
                Member member = new Member
                {
                    FirstName = "Navendu 123 " + number,
                    LastName = "Kumar",
                    MobileNumber = 9802293243,
                    UserName = "9802293243",
                    ClientIPAddress = "1.2.3.4",
                    DistrictId = 1,
                    PartnerDistricts = new List<PartnerDistrict>
                        {
                            new PartnerDistrict { DistrictId = 1 },
                            new PartnerDistrict { DistrictId = 2 }
                        }
                };
                int memberId = 0;
                repo.UpdateMemberProfile(memberId, member);            
            }
        }

        [TestMethod()]
        public void UpdateMember()
        {
            Random r = new Random();
            var number = r.Next(1, 100000);
            using (var repo = new MemberRepository())
            {
                int memberId = 1;
                Member member = repo.GetMemberProfile(memberId);
                member.LastName = "Kumar - updated";                
                repo.UpdateMemberProfile(memberId, member);
            }
        }
    }
}
