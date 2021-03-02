using System;
using System.Numerics;

namespace Arithmetic
{
    class Program
    {
        // Factorial with a cycle for
        static BigInteger Factorial(BigInteger number)
        {
            BigInteger result = 1;

            for (BigInteger factor = 2; factor <= number; factor++)
            {
                result *= factor;
            }

            return result;
        }

        // Factorial with a recursion
        static BigInteger FactorialRecursion(BigInteger number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return number * FactorialRecursion(number - 1);
            }

        }



        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(10000));
        }
    }
}
