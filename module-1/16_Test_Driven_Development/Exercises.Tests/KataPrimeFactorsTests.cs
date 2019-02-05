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

        [TestMethod]
        public void Factorize_PrimeNumber_MultipleFactors()
        {
            CollectionAssert.AreEqual(new List<int>() { 2, 2 }, kataPrimeFactors.Factorize(4));
            CollectionAssert.AreEqual(new List<int>() { 2, 3 }, kataPrimeFactors.Factorize(6));
            CollectionAssert.AreEqual(new List<int>() { 2, 2, 2 }, kataPrimeFactors.Factorize(8));
            CollectionAssert.AreEqual(new List<int>() { 3, 3 }, kataPrimeFactors.Factorize(9));
            CollectionAssert.AreEqual(new List<int>() { 2, 5}, kataPrimeFactors.Factorize(10));
            CollectionAssert.AreEqual(new List<int>() { 2, 2, 2, 5, 5 }, kataPrimeFactors.Factorize(200));
        }



    }
}
