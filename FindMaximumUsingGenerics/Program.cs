using System;

namespace FindMaximumUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find max Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(2, 1, 3);
            Console.WriteLine(output);
        }
    }
}
