using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwamaanShaadi.DataLayer;
using SwamaanShaadi.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace SwamaanShaadi.DataLayer.Tests
//{
//    [TestClass()]
//    public class MemberRepositoryTests
//    {
//        [TestMethod()]
//        public void FindMemberTest()
//        {
//            using (var repo = new MemberRepository(new UnitOfWorkForMembers()))
//            {
//                foreach (var member in repo.AllIncluding(m=>m.AccountStatus).ToList())
//                {
//                    Console.WriteLine(member.FirstName + " " + member.AccountStatus.Status);
//                }
//            }
//        }

//        [TestMethod()]
//        public void RegisterNewMemberTest()
//        {
//            Random r = new Random();
//            var number = r.Next(1, 100000);
//            using (var uow = new UnitOfWorkForMembers())
//            {
//                uow.Context.Database.Log = Console.WriteLine;
//                using (var repo = new MemberRepository(uow))
//                {
//                    Member member = new Member
//                    {
//                        FirstName = "Navendu " + number,
//                        LastName = "Kumar",
//                        MobileNumber = 9802293243,
//                        UserName = "9802293243",
//                        ClientIPAddress = "1.2.3.4",
//                        DistrictId = 1,
//                        PartnerDistricts = new List<PartnerDistrict>
//                        {
//                            new PartnerDistrict { DistrictId = 1 },
//                            new PartnerDistrict { DistrictId = 2 }
//                        },
//                        State = State.Added
//                    };

//                    repo.InsertOrUpdate(member);
//                    uow.Save();
//                }
//            }
//        }

//        [TestMethod()]
//        public void UpdateMemberDistrict()
//        {
//            using (var uow = new UnitOfWorkForMembers())
//            {
//                uow.Context.Database.Log = Console.WriteLine;
//                using (var repo = new MemberRepository(uow))
//                {
//                    var member = repo.AllIncluding(t => t.PartnerDistricts).SingleOrDefault(t=>t.MemberId == 7);

//                    if (member.PartnerDistricts.Any())
//                    {
//                        member.PartnerDistricts.AddRange(
//                            new List<PartnerDistrict> {
//                                new PartnerDistrict { DistrictId = 3 }
//                            }
//                            ); 
//                    }
                    
//                    uow.Save();
//                }
//            }
//        }
//    }
//}
