using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Test
{
    [TestClass]
    public class StringCalculatorTests
    {
        StringCalculator stringCalculator;

        [TestInitialize]
        public void Initialize()
        {
            stringCalculator = new StringCalculator();
        }

        [TestMethod]
        public void Add_EmptyString_Zero()
        {
            Assert.AreEqual(0, stringCalculator.Add(""));
        }

        [TestMethod]
        public void Add_NotANumber_Zero()
        {
            Assert.AreEqual(0, stringCalculator.Add("a"));
            Assert.AreEqual(0, stringCalculator.Add("a,t,y,a,s,f"));
        }

        [TestMethod]
        public void Add_IgnoreNonNumeric()
        {
            Assert.AreEqual(20, stringCalculator.Add("a,5,10,2,f,3"));
            Assert.AreEqual(3, stringCalculator.Add("a,3"));
        }

        [TestMethod]
        public void Add_WrongDelimiter_Zero()
        {
            Assert.AreEqual(0, stringCalculator.Add("43 12 48 21"));
        }

        [TestMethod]
        public void Add_SingleEntries_NoAddition()
        {
            Assert.AreEqual(1, stringCalculator.Add("1"));
            Assert.AreEqual(32, stringCalculator.Add("32"));
            Assert.AreEqual(-5, stringCalculator.Add("-5"));
            Assert.AreEqual(0, stringCalculator.Add("0"));
        }

        [TestMethod]
        public void Add_NegativeNumbers()
        {
            Assert.AreEqual(-10, stringCalculator.Add("-8,-2"));
            Assert.AreEqual(-10, stringCalculator.Add("-20,10"));
            Assert.AreEqual(0, stringCalculator.Add("-20,10,10"));
        }

        [TestMethod]
        public void Add_PositiveNumbers()
        {
            Assert.AreEqual(10, stringCalculator.Add("8,2"));
            Assert.AreEqual(30, stringCalculator.Add("20,10"));
            Assert.AreEqual(40, stringCalculator.Add("20,10,10"));
            Assert.AreEqual(45, stringCalculator.Add("1,2,3,4,5,6,7,8,9,0"));
        }

        [TestMethod]
        public void Add_NewLineAndCommaDelimiters()
        {
            Assert.AreEqual(10, stringCalculator.Add("8\n2"));
            Assert.AreEqual(30, stringCalculator.Add("20\n10"));
            Assert.AreEqual(40, stringCalculator.Add("20,10\n10"));
            Assert.AreEqual(45, stringCalculator.Add("1,2,3,4,5\n6,7,8,9,0\n"));
        }
    }
}
