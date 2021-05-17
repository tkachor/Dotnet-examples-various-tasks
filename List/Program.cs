using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{  

    class Program
    {
        static int LargestNumber(List<int> number)
        {
            int result = 0;

            result = (from n in number select n).Max();

            return result;
        }

        static int MinimaltNumber(List<int> number)
        {
            int result = 0;

            result = (from n in number select n).Min();

            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
