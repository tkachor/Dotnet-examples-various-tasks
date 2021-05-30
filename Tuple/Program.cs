using System;

namespace Tuple
{
    class Program
    {

        //Returning two or more values from a function
        private static (int, int) GetValues()
        {
            var result = (1, 3);
            return result;
        }

        //Return a tuple of two integer elements
        private static (int sum, int count) GetNamedValues(int[] numbers)
        {
            var result = (sum: 0, count: 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.count++;
            }

            return result;
        }


        static void Main(string[] args)
        {
           
        }
    }
}
