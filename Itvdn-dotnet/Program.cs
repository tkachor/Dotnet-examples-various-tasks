using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Itvdn_dotnet
{

   

    class Program
    {

        static int[] MultiplyAll(int[] arr, int numberr) => arr.Select(x => x * numberr).ToArray();


        static void Main()
        {
            foreach (var item in MultiplyAll(new int[] { 1, 2, 3 }, 2)) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
