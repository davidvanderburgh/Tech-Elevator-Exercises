using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
        KataRomanNumerals kata;

        [TestInitialize]
        public void Initialize()
        {
            kata = new KataRomanNumerals();
        }

        [TestMethod]
        public void RomanNumeral_Ones()
        {
            Assert.AreEqual("I", kata.ConvertToRomanNumeral(1));
            Assert.AreEqual("II", kata.ConvertToRomanNumeral(2));
            Assert.AreEqual("III", kata.ConvertToRomanNumeral(3));
        }

        [TestMethod]
        public void RomanNumeral_Fives()
        {
            Assert.AreEqual("V", kata.ConvertToRomanNumeral(5));
            Assert.AreEqual("VI", kata.ConvertToRomanNumeral(6));
            Assert.AreEqual("VII", kata.ConvertToRomanNumeral(7));
        }

        [TestMethod]
        public void RomanNumeral_Tens()
        {
            Assert.AreEqual("X", kata.ConvertToRomanNumeral(10));
            Assert.AreEqual("XI", kata.ConvertToRomanNumeral(11));
            Assert.AreEqual("XV", kata.ConvertToRomanNumeral(15));
            Assert.AreEqual("XXVI", kata.ConvertToRomanNumeral(26));
        }
    }
}
