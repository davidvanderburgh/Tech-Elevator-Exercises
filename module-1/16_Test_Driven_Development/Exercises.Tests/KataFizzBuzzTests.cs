using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        //1 gives "1"
        //3 gives "Fizz"
        //5 gives "Buzz"
        //15 gives "FizzBuzz"
        //22 gives "22"
        //0 gives ""

        KataFizzBuzz kataFizzBuzz;

        [TestInitialize]
        public void Initialize()
        {
            kataFizzBuzz = new KataFizzBuzz();
        }


        [TestMethod]
        public void FizzBuzz_DivisibleBy3Only_Fizz()
        {
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(3));
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(6));
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(9));
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(12));
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(18));
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(21));
        }

        [TestMethod]
        public void FizzBuzz_DivisibleBy5Only_Buzz()
        {
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(5));
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(10));
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(20));
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(25));
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(55));
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(40));
        }

        [TestMethod]
        public void FizzBuzz_DivisibleBy3And5_FizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", kataFizzBuzz.FizzBuzz(15));
            Assert.AreEqual("FizzBuzz", kataFizzBuzz.FizzBuzz(30));
            Assert.AreEqual("FizzBuzz", kataFizzBuzz.FizzBuzz(45));
            Assert.AreEqual("FizzBuzz", kataFizzBuzz.FizzBuzz(60));
            Assert.AreEqual("FizzBuzz", kataFizzBuzz.FizzBuzz(75));
            Assert.AreEqual("FizzBuzz", kataFizzBuzz.FizzBuzz(90));
        }

        [TestMethod]
        public void FizzBuzz_Inside0To100NotDivisibleBy3Or5_NumberAsString()
        {
            Assert.AreEqual("2", kataFizzBuzz.FizzBuzz(2));
            Assert.AreEqual("17", kataFizzBuzz.FizzBuzz(17));
            Assert.AreEqual("82", kataFizzBuzz.FizzBuzz(82));
            Assert.AreEqual("98", kataFizzBuzz.FizzBuzz(98));
            Assert.AreEqual("16", kataFizzBuzz.FizzBuzz(16));
        }

        [TestMethod]
        public void FizzBuzz_NumbersOutsideOf1To100_EmptyString()
        {
            Assert.AreEqual("", kataFizzBuzz.FizzBuzz(0));
            Assert.AreEqual("", kataFizzBuzz.FizzBuzz(-3));
            Assert.AreEqual("", kataFizzBuzz.FizzBuzz(180));
            Assert.AreEqual("", kataFizzBuzz.FizzBuzz(820));
            Assert.AreEqual("", kataFizzBuzz.FizzBuzz(-98));
            Assert.AreEqual("", kataFizzBuzz.FizzBuzz(-15));
        }

        [TestMethod]
        public void FizzBuzz_NumberContainsA3Only_Fizz()
        {
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(3));
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(13));
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(23));
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(43));
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(83));
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(73));
        }

        [TestMethod]
        public void FizzBuzz_NumberContainsA5Only_Buzz()
        {
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(5));
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(25));
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(50));
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(85));
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(56));
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(95));
        }
    }
}
