using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine(a == 17 && b == 4 ? $"{a} / {b} is {quotient} with a remainder of {remainder}." : "Unsolvable!");
        }
    }
}
