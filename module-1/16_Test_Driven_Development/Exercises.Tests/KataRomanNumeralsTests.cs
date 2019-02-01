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
    }
}
