using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialization of a one-dimensional array
            int[] integerArray1 = new int[5];
            int[] integerArray2 = { 0, 1, 2, 3, 4 };
            int[] integerArray3 = new int[] { 0, 1, 2, 3, 4 };
            int[] integerArray4 = new int[5] { 0, 1, 2, 3, 4 };

            // Sorting elements of array
            Array.Sort(integerArray3);

            // Reverse elements of array
            Array.Reverse(integerArray4);

            // Initialization of a two-dimensional array
            int[,] integerArray5 = {
                             { 1, 2 },
                             { 3, 4 },
                             { 5, 6 }
                           };

            // Initialization of a three-dimensional array
            int[,,] integerArray6 = new int[3, 2, 3]
           {
                {
                    { 1, 2, 3 },                   
                    { 7, 8, 9 }
                },
                {
                    { 1, 2, 3 },                   
                    { 7, 8, 9 }
                },
                {
                    { 1, 2, 3 },                  
                    { 7, 8, 9 }
                }
           };
            
            for (int i = 0; i < integerArray6.GetLength(0); i++)
                for (int j = 0; j < integerArray6.GetLength(1); j++)
                    for (int k = 0; k < integerArray6.GetLength(2); k++)
                        Console.Write($"{integerArray6[i, j, k]} ");


            // Initialization of a jagged array v.1
            byte[] array0 = new byte[] { 1, 2, 3 };
            byte[] array1 = new byte[] { 1, 2, 3, 4, 5 };
            byte[] array2 = new byte[] { 1, 2 };

            byte[][] jaggedArray1 = new byte[3][] { array0, array1, array2 };


            // Initialization of a jagged array v.2
            byte[][] jaggedArray2 = new byte[3][];

            jaggedArray2[0] = array0;
            jaggedArray2[1] = array1;
            jaggedArray2[2] = array2;


            // Initialization of a jagged array v.3
            byte[][] jaggedArray3 =
                {
                    new byte[] { 1, 2, 3 },
                    new byte[] { 1, 2, 3, 4, 5 },
                    new byte[] { 1, 2 }
                };
        }
    }

    public static class ArraysTask
    {
        // Add Element ToArray with method CopyTo
        public static T[] AddElementToArrayCopyTo<T>(this T[] array, T item)
        {
            if (array == null)
            {
                return new[] { item };
            }
            T[] result = new T[array.Length + 1];
            array.CopyTo(result, 0);
            result[array.Length] = item;
            return result;
        }

        // Add Element ToArray with Linq method Concat
        public static T[] AddElementToArrayConcat<T>(this T[] array, T item)
        {
            if (array == null)
            {
                return new T[] { item };
            }
            return array.Concat(new T[] { item }).ToArray();
        }

        // Add Element ToArray with methot Resize
        public static T[] AddElementToArrayResize<T>(this T[] array, T item)
        {
            if(array == null)
            {
                return new T[] { item };
            }
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;

            return array;
        }

        // Add Element ToArray with convert to List
        public static T[] Append<T>(this T[] array, T item)
        {
            List<T> list = new List<T>(array);
            list.Add(item);

            return list.ToArray();
        }



    }
}
