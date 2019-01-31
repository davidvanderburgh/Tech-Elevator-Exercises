using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        [TestMethod]
        public void GetHerdTestProgrammer()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            string result = animalGroupName.GetHerd("programmer");

            Assert.AreEqual("unknown", result);
        }

        [TestMethod]
        public void GetHerdTestDog()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            string result = animalGroupName.GetHerd("dog");

            Assert.AreEqual("Pack", result);
        }
    }
}
