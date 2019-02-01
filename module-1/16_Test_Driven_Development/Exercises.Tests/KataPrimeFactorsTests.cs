using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class KataPrimeFactorsTests
    {
        KataPrimeFactors kataPrimeFactors;

        [TestInitialize]
        public void Initialize()
        {
            kataPrimeFactors = new KataPrimeFactors();
        }

        [TestMethod]
        public void Factorize_PrimeNumber_SingleNumber()
        {
            CollectionAssert.AreEqual(new List<int>() { 2 }, kataPrimeFactors.Factorize(2));
            CollectionAssert.AreEqual(new List<int>() { 3 }, kataPrimeFactors.Factorize(3));
            CollectionAssert.AreEqual(new List<int>() { 7 }, kataPrimeFactors.Factorize(7));
        }




    }
}
