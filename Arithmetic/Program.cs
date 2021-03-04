using System;
using System.Numerics;

namespace Arithmetic
{
    class Program
    {
        // Iterative Factorial 
        static BigInteger Factorial(BigInteger number)
        {
            BigInteger result = 1;

            for (BigInteger factor = 2; factor <= number; factor++)
            {
                result *= factor;
            }

            return result;
        }

        // Recursion Factorial 
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

        // Iterative Fibonacci  
        static int Fibonacci(int number)
        {
            if (number == 0) return 0;

            int prev = 0;
            int next = 1;
            for (int i = 1; i < number; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
        }

        // Recursion Fibonacci  
        static int FibonacciRecursion(int number)
        {
            if (number < 2)
            {
                return number;
            }
            else
            {
                return FibonacciRecursion(number - 1) + FibonacciRecursion(number - 2);                
            }
        }

        // 

        static ulong Power(uint x, uint n)
        {
            ulong res = 1;
            for (uint i = 0; i < n; i++)
                res *= x;
            return res;
        }

        //

        double resultPow = Math.Pow(2, 2);
        



        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciRecursion(15));
        }
    }
}
