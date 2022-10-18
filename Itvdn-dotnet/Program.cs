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
using static System.Net.Mime.MediaTypeNames;

namespace Itvdn_dotnet
{
    class Program
    {
        public static string DuplicateEncode(string word)
        {
            var charArr = word.ToLower().ToCharArray();
            
            char[] result = new char[charArr.Length];

            for (int i = 0; i < charArr.Length; i++)
            {
                result[i] = (Array.LastIndexOf(charArr, charArr[i]) != Array.IndexOf(charArr, charArr[i])) ? ')' : '(';                
            }

            return String.Join("", result);
        }

      

        static void Main()
        {
            Console.WriteLine(DuplicateEncode("recede"));
            
        }
    }
}
