using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void GetCount_abacb_b2c1a2()
        {
            WordCount wordCount = new WordCount();
            string[] words = { "a", "b", "a", "c", "b" };
            Dictionary<string, int> result = wordCount.GetCount(words);
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                { "b", 2 },
                { "a", 2 },
                { "c", 1 }
            };

            CollectionAssert.AreEquivalent( expected, result);
        }


    }
}
