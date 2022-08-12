using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Itvdn_dotnet
{   
    
    public static class Test
    {
       


        public static T[] RemoveElement<T>( T[] array, T item)
        {
            List<T> list = new List<T>(array);

            list.Remove(item);

            return list.ToArray();
        }

    }
    class Program
    {
        static void Main()
        {
            int[] integerArray4 = new int[5] { 23, 441, 42, 23, 467 };


            int[] result = Test.RemoveElement(integerArray4, 23);

            Array.Sort(result);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }



    }
}
