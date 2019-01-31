using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        [TestMethod]
        public void MakeArray_123_333()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();
            int[] input = { 1, 2, 3 };
            int[] result = maxEnd3.MakeArray(input);
            int[] expected = { 3, 3, 3 };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
