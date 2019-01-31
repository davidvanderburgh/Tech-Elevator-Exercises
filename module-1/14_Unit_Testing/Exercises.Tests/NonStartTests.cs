using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        [TestMethod]
        public void GetPartialString_shotljava_hotlava()
        {
            NonStart nonstart = new NonStart();
            string result = nonstart.GetPartialString("shotl", "java");
            Assert.AreEqual("hotlava", result);
        }
    }
}
