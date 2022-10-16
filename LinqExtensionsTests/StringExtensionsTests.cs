using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExtensionsTests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        [DataRow(false,"test","a","b","C")]
        [DataRow(true,"test","this","is","just","a","testOrIsIt?")]
        public void IsStringInArrayTest(bool expectedResult, string toSearch, params string[] sources)
        {
            //Act
            var result = sources.IsStringInArray(toSearch);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(0, "test", "a", "b", "C")]
        [DataRow(20, "test5", "this10", "is8", "just-3", "a0", "testOrIsIt?")]
        public void SumNumsInStringsTest(long expected, params string[] sources)
        {
            //Act
            var result = sources.SumNumsInStrings();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
