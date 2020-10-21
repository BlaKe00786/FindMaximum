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
        [TestMethod]
        [DataRow(3.3, 2.2, 1.1)]
        [DataRow(1.1, 3.3, 2.2)]
        [DataRow(1.1, 2.2, 3.3)]
        public void MaximumFloatGivenAtDifferentPositions(double first, double second, double third)
        {
            double expected = 3.3;
            double output = MaximumNumberCheck.MaximumFloatNumber(first, second, third);
            Assert.AreEqual(expected, output);
        }
    }
}
