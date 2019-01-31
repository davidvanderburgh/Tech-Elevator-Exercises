using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [TestMethod]
        public void HaveParty_30CigarsWeekday_False()
        {
            CigarParty cp = new CigarParty();
            bool result = cp.HaveParty(30, false);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void HaveParty_50CigarsWeekday_True()
        {
            CigarParty cp = new CigarParty();
            bool result = cp.HaveParty(50, false);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void HaveParty_70CigarsWeekend_True()
        {
            CigarParty cp = new CigarParty();
            bool result = cp.HaveParty(70, true);
            Assert.AreEqual(true, result);
        }
        

    }
}
