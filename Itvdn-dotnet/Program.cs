using System;
using System.Collections.Generic;
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

        public static string GenerateShape(int n)
        {

            string result = String.Empty;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    result += '+';
                }

                result += '\n';
            }

            return result;
        }



        static void Main()
        {

            Console.WriteLine(GenerateShape(5));
           
        }
    }
}
