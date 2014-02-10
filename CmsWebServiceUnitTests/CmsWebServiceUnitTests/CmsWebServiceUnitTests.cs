using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CmsWebServiceUnitTests
{
    using NUnit.Framework;
    using CmsWebService;

    [TestFixture]
    public class CmsWebServiceUnitTests
    {
        private CmsWebService.CmsWebService cmsWeb;

        [SetUp]
        public void Init()
        {
            cmsWeb = new CmsWebService.CmsWebService();
        }

        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1, "1 is not equal to 1 !");
        }

        [Test]
        public void AddBonusTest()
        {
            CmsWebService.Bonus lb = new Bonus() { Name = "Bonus1", Description = "Very nice bonus 1", Price = 200m };
            int id = cmsWeb.AddBonus(lb);
            CmsWebService.Bonus lb2 = cmsWeb.GetBonus(id);

            Assert.AreEqual(id, lb2.BonusId, "Bonuses have different ids!");
            Assert.AreEqual(lb.Name, lb2.Name, "Bonuses have different names!");
            Assert.AreEqual(lb.Description, lb2.Description, "Bonuses have different descriptions!");
            Assert.AreEqual(lb.Price, lb2.Price, "Bonuses have different prices!");
        }
    }
}
