using System;

namespace FindMaximumUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find max Number");
            int intOutput = MaximumNumberCheck.MaximumIntegerNumber(2, 1, 3);
            Console.WriteLine(intOutput);
            double doubleOutput = MaximumNumberCheck.MaximumFloatNumber(1.1, 2.2, 3.3);
            Console.WriteLine(doubleOutput);
        }
    }
}
