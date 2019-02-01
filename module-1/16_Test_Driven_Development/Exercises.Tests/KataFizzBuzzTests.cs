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
    }
}
