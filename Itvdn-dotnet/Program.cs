using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Itvdn_dotnet
{
    class Program
    {

        public static int CalculateSquareOfSum(int max)
        {
            return (int)Math.Pow(Enumerable.Range(1, max).Sum(), 2); 
        }

        public static int CalculateSumOfSquares(int max)
        {
            //return Enumerable.Range(1, max).Aggregate((a, b) => (int)Math.Pow(a, 2) + (int)Math.Pow(b, 2));

            return Enumerable.Range(1, max).Select(a => (int)Math.Pow(a, 2)).Sum();
        }

        //


        static void Main()
        {
            Console.WriteLine(CalculateSumOfSquares(10));
        }
    }
}
