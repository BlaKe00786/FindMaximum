using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumUsingGenerics;
namespace MaximumNumberTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMaximum()
        {
            int expectedInt= 4;
            double expectedDouble = 4.4;
            string expectedString = "333";
            int[] intArray = { 1, 2, 3, 4 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            int outputInt = generic.PrintMaxValue();
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            double outputDouble = genericDouble.PrintMaxValue();
            string[] stringArray = { "111", "222", "333" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            string outputString = genericString.PrintMaxValue();
            Assert.AreEqual(expectedInt,outputInt);
            Assert.AreEqual(expectedDouble,outputDouble);
            Assert.AreEqual(expectedString,outputString);
        }
    }
}
