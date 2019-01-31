using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        [TestMethod]
        public void IsItTheSame_1231_True()
        {
            SameFirstLast sameFirstLast = new SameFirstLast();
            int[] input = { 1, 2, 3, 1 };
            bool result = sameFirstLast.IsItTheSame(input);
            Assert.AreEqual(true, result);
        }
    }
}
