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

        public static string ReverseLetter(string str) => new string(Regex.Replace(str, "[^A-Za-z]", "").ToCharArray().Reverse().ToArray());


        static void Main()
        {
            Console.WriteLine(ReverseLetter("ul43543543!!!!!!tr53o?n"));
           
;
        }
    }
}
