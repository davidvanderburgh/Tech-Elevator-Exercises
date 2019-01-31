using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        [TestMethod]
        public void GetLucky_No1sNo3s_True()
        {
            Lucky13 lucky13 = new Lucky13();
            int[] nums = { 0, 2, 4 };
            bool result = lucky13.GetLucky(nums);
            Assert.AreEqual(true, result);
        }
    }
}
