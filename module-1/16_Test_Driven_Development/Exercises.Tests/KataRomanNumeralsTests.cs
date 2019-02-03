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
            Assert.AreEqual("MCMXCVIII", kata.ConvertToRomanNumeral(1998));
        }

        [TestMethod]
        public void ConvertToDigit_Ones()
        {
            Assert.AreEqual(1, kata.ConvertToDigit("I"));
            Assert.AreEqual(2, kata.ConvertToDigit("II"));
            Assert.AreEqual(3, kata.ConvertToDigit("III"));
        }

        [TestMethod]
        public void ConvertToDigit_Fives()
        {
            Assert.AreEqual(5, kata.ConvertToDigit("V"));
            Assert.AreEqual(6, kata.ConvertToDigit("VI"));
            Assert.AreEqual(7, kata.ConvertToDigit("VII"));
        }

        [TestMethod]
        public void ConvertToDigit_Tens()
        {
            Assert.AreEqual(10, kata.ConvertToDigit("X"));
            Assert.AreEqual(11, kata.ConvertToDigit("XI"));
            Assert.AreEqual(15, kata.ConvertToDigit("XV"));
            Assert.AreEqual(26, kata.ConvertToDigit("XXVI"));
        }

        [TestMethod]
        public void ConvertToDigit_Fifties()
        {
            Assert.AreEqual(50, kata.ConvertToDigit("L"));
            Assert.AreEqual(60, kata.ConvertToDigit("LX"));
            Assert.AreEqual(78, kata.ConvertToDigit("LXXVIII"));
        }

        [TestMethod]
        public void ConvertToDigit_OtherPlaceholders()
        {
            Assert.AreEqual(100, kata.ConvertToDigit("C"));
            Assert.AreEqual(500, kata.ConvertToDigit("D"));
            Assert.AreEqual(1000, kata.ConvertToDigit("M"));
        }

        [TestMethod]
        public void ConvertToDigit_Subtractive()
        {
            Assert.AreEqual(1004, kata.ConvertToDigit("MIV"));
            Assert.AreEqual(504, kata.ConvertToDigit("DIV"));
            Assert.AreEqual(462, kata.ConvertToDigit("CDLXII"));
            Assert.AreEqual(499, kata.ConvertToDigit("CDXCIX"));
            Assert.AreEqual(41, kata.ConvertToDigit("XLI"));
            Assert.AreEqual(95, kata.ConvertToDigit("XCV"));
            Assert.AreEqual(1998, kata.ConvertToDigit("MCMXCVIII"));
        }
    }
}
