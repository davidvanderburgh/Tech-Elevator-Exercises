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
        public void ConvertToRomanNumeral_Ones()
        {
            Assert.AreEqual("I", kata.ConvertToRomanNumeral(1));
            Assert.AreEqual("II", kata.ConvertToRomanNumeral(2));
            Assert.AreEqual("III", kata.ConvertToRomanNumeral(3));
        }

        [TestMethod]
        public void ConvertToRomanNumeral_Fives()
        {
            Assert.AreEqual("V", kata.ConvertToRomanNumeral(5));
            Assert.AreEqual("VI", kata.ConvertToRomanNumeral(6));
            Assert.AreEqual("VII", kata.ConvertToRomanNumeral(7));
        }

        [TestMethod]
        public void ConvertToRomanNumeral_Tens()
        {
            Assert.AreEqual("X", kata.ConvertToRomanNumeral(10));
            Assert.AreEqual("XI", kata.ConvertToRomanNumeral(11));
            Assert.AreEqual("XV", kata.ConvertToRomanNumeral(15));
            Assert.AreEqual("XXVI", kata.ConvertToRomanNumeral(26));
        }

        [TestMethod]
        public void ConvertToRomanNumeral_Fifties()
        {
            Assert.AreEqual("L", kata.ConvertToRomanNumeral(50));
            Assert.AreEqual("LX", kata.ConvertToRomanNumeral(60));
            Assert.AreEqual("LXXVIII", kata.ConvertToRomanNumeral(78));
        }

        [TestMethod]
        public void ConvertToRomanNumeral_OtherPlaceholders()
        {
            Assert.AreEqual("C", kata.ConvertToRomanNumeral(100));
            Assert.AreEqual("D", kata.ConvertToRomanNumeral(500));
            Assert.AreEqual("M", kata.ConvertToRomanNumeral(1000));
        }

        [TestMethod]
        public void ConvertToRomanNumeral_Subtractive()
        {
            Assert.AreEqual("MIV", kata.ConvertToRomanNumeral(1004));
            Assert.AreEqual("DIV", kata.ConvertToRomanNumeral(504));
            Assert.AreEqual("CDLXII", kata.ConvertToRomanNumeral(462));
            Assert.AreEqual("CDXCIX", kata.ConvertToRomanNumeral(499));
            Assert.AreEqual("XLI", kata.ConvertToRomanNumeral(41));
            Assert.AreEqual("XCV", kata.ConvertToRomanNumeral(95));
        }

        [TestMethod]
        public void ConvertToDigit_XXIV_24()
        {
            Assert.AreEqual(24, kata.ConvertToDigit("XXIV"));
        }

        [TestMethod]
        public void ConvertToDigit_III_3()
        {
            Assert.AreEqual(3, kata.ConvertToDigit("III"));
        }

        [TestMethod]
        public void ConvertToDigit_MCMXCVIII_1998()
        {
            Assert.AreEqual(1998, kata.ConvertToDigit("MCMXCVIII"));
        }
    }
}
