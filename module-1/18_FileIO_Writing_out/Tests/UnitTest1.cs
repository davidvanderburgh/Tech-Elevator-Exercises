using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FizzWriter.Tests
{
    [TestClass]
    public class FizzWriterTests
    {
        [TestMethod]
        public void GetFizzBuzzTests_Fizz()
        {
            Assert.AreEqual("Fizz", FizzBuzzWriter.GetFizzBuzz(3));
            Assert.AreEqual("Fizz", FizzBuzzWriter.GetFizzBuzz(13));
            Assert.AreEqual("Fizz", FizzBuzzWriter.GetFizzBuzz(6));
        }

        [TestMethod]
        public void GetFizzBuzzTests_Buzz()
        {
            Assert.AreEqual("Buzz", FizzBuzzWriter.GetFizzBuzz(5));
            Assert.AreEqual("Buzz", FizzBuzzWriter.GetFizzBuzz(10));
            Assert.AreEqual("Buzz", FizzBuzzWriter.GetFizzBuzz(20));
            Assert.AreEqual("Buzz", FizzBuzzWriter.GetFizzBuzz(52));
        }

        [TestMethod]
        public void GetFizzBuzzTests_FizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzzWriter.GetFizzBuzz(15));
            Assert.AreEqual("FizzBuzz", FizzBuzzWriter.GetFizzBuzz(30));
            Assert.AreEqual("FizzBuzz", FizzBuzzWriter.GetFizzBuzz(45));
        }
    }
}
