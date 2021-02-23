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
