using System;

namespace FindMaximumUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4};
            GenericMaximum<int> genericInt = new GenericMaximum<int>(intArray);
            Console.WriteLine("Maximum value is " + genericInt.PrintMaxValue());
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4};
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            Console.WriteLine("Maximum value is " + genericDouble.PrintMaxValue());
            string[] stringArray = { "111", "222", "333"};
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            Console.WriteLine("Maximum value is " + genericString.PrintMaxValue());
        }
    }
}
