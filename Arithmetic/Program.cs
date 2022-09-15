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

        //Reverse a Number
        static int ReverseNumber(int number)
        {
            int result = 0;

            while (number != 0)
            {
                result = (result * 10) + (number % 10);
                number = number / 10;
            }

            return result;
        }

        //Random number
        static int RandomNumber(int range)
        {
            Random random = new Random();            
            return random.Next(range);
        }

        //Is a Duck Number
        static bool IsADuckNumber(int number)
        {
            string strNumbr = Convert.ToString(number);
            int numberLength = strNumbr.Length;
            int temp = 0;
            char ch;

            for (int i = 1; i < numberLength; i++)
            {
                ch = strNumbr[i];
                if (ch == '0')
                    temp++;     
            }

            char f = strNumbr[0];

            if (temp > 0 && f != '0')
                return true;
            else
                return false;
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

        // //(6 kyu - https://www.codewars.com/)
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        public static int Solution(int value)
        {
            List<int> list = new List<int>();

            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    list.Add(i);
                }
            }

            return value <= 0 ? 0 : list.Distinct().Aggregate((a, b) => a + b);
        }



        static void Main(string[] args)
        {
            long l = 43254;
            string str = l.ToString();
            Console.WriteLine(str);
        }
    }
}
