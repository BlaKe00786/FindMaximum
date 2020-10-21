using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumUsingGenerics;
namespace MaximumNumberTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(3,2,1)]
        [DataRow(1,3,2)]
        [DataRow(1,2,3)]
        public void MaximumIntegerGivenAtDifferentPositions(int first, int second,int third)
        {
            int expected = 3;
            int output=MaximumNumberCheck.MaximumIntegerNumber(first, second, third);
            Assert.AreEqual(expected, output);
        }
    }
}
