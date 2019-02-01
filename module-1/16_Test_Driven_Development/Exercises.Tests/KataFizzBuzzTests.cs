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

        KataFizzBuzz fizzBuzz;

        [TestInitialize]
        public void Initialize()
        {
            fizzBuzz = new KataFizzBuzz();
        }


        [TestMethod]
        public void FizzBuzz_DivisibleBy3Only_Fizz()
        {
            Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(3));
            Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(6));
            Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(9));
            Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(12));
            Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(18));
            Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(21));
        }
    }
}
