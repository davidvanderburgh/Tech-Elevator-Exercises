using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        [TestMethod]
        public void GetBits_Hello_Hlo()
        {
            StringBits stringbits = new StringBits();
            string result = stringbits.GetBits("Hello");
            Assert.AreEqual("Hlo", result);
        }
    }
}
