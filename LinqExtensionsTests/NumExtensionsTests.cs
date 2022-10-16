using LinqExtensions;

namespace LinqExtensionsTests
{
    [TestClass]
    public class NumExtensionsTests
    {
        [TestMethod]
        public void DuplicateIntsTest()
        {
            //Arrange
            var input = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 55, 66, 77, 2, 5, 8, -2 };

            //Act
            var duplicateInts = input.DuplicateInts().ToList();

            //Assert
            Assert.AreEqual(3, duplicateInts.Count());
            Assert.IsTrue(duplicateInts[0] == 2);
            Assert.IsTrue(duplicateInts[1] == 5);
            Assert.IsTrue(duplicateInts[2] == 8);
        }

        [TestMethod]
        public void MultipyWithFactorTest()
        {
            //Arrange
            var input = new List<int> { 1,10,4 };

            //Act
            var duplicateInts = input.MultipyWithFactor(1.5).ToList();

            //Assert
            Assert.AreEqual(3, duplicateInts.Count());
            Assert.IsTrue(duplicateInts[0] == 1.5);
            Assert.IsTrue(duplicateInts[1] == 15);
            Assert.IsTrue(duplicateInts[2] == 6);
        }

        [TestMethod]
        public void MeanTest()
        {
            //Arrange
            var input1 = new List<int> { 20, 1 , 2 ,3 };
            var input2 = new List<int> { 20, 4 , 2 ,3, 1 };

            //Act
            var mean1 = input1.Mean();
            var mean2 = input2.Mean();

            //Assert
            Assert.AreEqual(2.5, mean1);
            Assert.AreEqual(3, mean2);
        }
    }
}