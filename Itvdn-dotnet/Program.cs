using System;
using System.Numerics;

namespace Itvdn_dotnet
{
    class Program
    {
        static void Main() { Method(2); }
        static void Method(int x = 1, int y = 2, int z = 3)
        {
            Method(2);
            Console.WriteLine(x);
        }
    }
}
