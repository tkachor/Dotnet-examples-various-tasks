using System;using System.Numerics;

namespace Itvdn_dotnet
{
    class Program
    {
        static int[] PairValuesArray(int n)
        {
            int[] arr = new int[n / 2 + 1];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = i * 2;
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] newArray = PairValuesArray(20);

            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
