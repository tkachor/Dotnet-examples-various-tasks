using System;
using System.Collections.Generic;
using System.Linq;
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

        //Raise the number to the power
        static ulong Power(uint x, uint n)
        {
            ulong res = 1;
            for (uint i = 0; i < n; i++)
                res *= x;
            return res;
        }

        //Raise the number to the power with Math
        double resultPow = Math.Pow(2, 2);
        

        //Is Prime number
        static bool IsPrimeNumber(int number)
        {
            bool result = true;

            if(number > 1)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;  
        }

        //Is Even number
        static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }

        //Is Odd number
        static bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }

        //Divide the number into numbers and return their sum
        static int SumOfNumbers(int number)
        {
            int result = 0;

            foreach (char c in number.ToString())
            {
                result += int.Parse(c.ToString());
            }

            return result;
        }

        //Return the missing number in the sorted array
        static int returnMissingNumber(int[] numbers)
        {
            for (int i = numbers[0]; i < numbers.Length; i++)
            {
                if (numbers[i] != i + 1)
                {
                    return i + 1;
                }
            }

            return 0;
        }

        //Сombine two arrays with Linq method Concat
        static int[] ConcatTwoArray(int[] arr1, int[] arr2)
        {
            int[] result = arr1.Concat(arr2).ToArray();

            return result;
        }

        //Сombine two arrays with Linq method Union without duplicates
        static int[] UnionTwoArray(int[] arr1, int[] arr2)
        {
            int[] result = arr1.Union(arr2).ToArray();

            return result;
        }

        //Сombine two arrays with Linq method CopyTo
        static int[] СombineTwoArray(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            arr1.CopyTo(result, 0);
            arr2.CopyTo(result, arr1.Length);

            return result;
        }

        //Сombine two arrays with Linq method SelectMany and params
        private static T[] Combine<T>(params IEnumerable<T>[] items) =>
                    items.SelectMany(i => i).ToArray();




        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 2, 4, 6, 45, 78, 3, 4, 65 };
            int[] arr2 = new int[] { 43, 4, 7, 8, 32, 223, 54 };

            var result = Combine(arr1, arr2, arr1);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}
