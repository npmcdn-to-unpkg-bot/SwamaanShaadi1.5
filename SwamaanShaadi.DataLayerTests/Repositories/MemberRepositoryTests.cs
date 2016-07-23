using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwamaanShaadi.DataLayer;
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
        public void AllIncludingTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertOrUpdateTest()
        {
            using (var repo = new MemberRepository())
            {
                foreach (var member in repo.All.ToList())
                {
                    Console.WriteLine(member.FirstName);
                }
            }
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }
    }
}