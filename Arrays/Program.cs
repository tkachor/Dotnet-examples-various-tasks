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
        // Add element to array with method CopyTo
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

        // Add element to array with Linq method Concat
        public static T[] AddElementToArrayConcat<T>(this T[] array, T item)
        {
            if (array == null)
            {
                return new T[] { item };
            }
            return array.Concat(new T[] { item }).ToArray();
        }

        // Add element to array with methot Resize
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

        // Add element to array with convert to list
        public static T[] Append<T>(this T[] array, T item)
        {
            List<T> list = new List<T>(array);
            list.Add(item);

            return list.ToArray();
        }

        //Break the number into numbers and return it to an array v.1
        static int[] NumberToArray(int number)
        {
            int lengthArray = number.ToString().Length;

            int[] arrayNumber = new int[lengthArray];

            for(int i = 0; i < lengthArray; i++)
            {
                foreach(var item in number.ToString())
                {
                    arrayNumber[i] = int.Parse(item.ToString());
                }
            }

            return arrayNumber;
        }
        
        //Divide the number into numbers and return it to an array v.2
        static int[] NumberToArrayVariantList(int number)
        {
            List<int> listNumbers = new List<int>();

            foreach(char item in number.ToString())
            {
                listNumbers.Add(int.Parse(item.ToString()));
            }

            return listNumbers.ToArray();
        }

        //Integer array inversion with loop   
        static int[] InversionIntegerArray(int[] array)
        {
            int length = array.Length;
            int midle = length / 2;
            int temp;
            for (int i = 0; i < midle; i++)
            {
                temp = array[i];
                array[i] = array[length - i - 1];
                array[length - i - 1] = temp;
            }

            return array;
        }

        //Integer array inversion with linq
        static int[] InversionIntegerArrayWithList(int[] array)
        {
            Array.Reverse(array);

            return array;
        }

        //Integer array sort with loop
        static int[] ArraySort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        //Integer array sort with linq
        static int[] ArraySortLinq(int[] array)
        {
            Array.Sort(array);

            return array;
        }

        //Max and min value in snteger array
        static int MinValueInArray(int[] array) 
        {
            int Lowest = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (Lowest > array[i])
                {
                    Lowest = array[i];
                }
            }
            return Lowest;
        }

        static int MaxValueInArray(int[] array)
        {
            int Highest = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (Highest < array[i])
                {
                    Highest = array[i];
                }
            }
            return Highest;
        }

        //Max and min value in integer array with linq
        static int MinValueInArrayLinq(int[] array)
        {            
            return array.Max();
        }

        static int MaxValueInArrayLinq(int[] array)
        {           
            return array.Min();
        }

        //Index of Max and min value in integer array with linq
        static int IndexOfMinValueInArray(int[] array)
        {
            return array.ToList().IndexOf(array.Max());
        }

        static int IndexOfMaxValueInArray(int[] array)
        {
            return array.ToList().IndexOf(array.Min());
        }

        //Сombine two arrays with Linq method Concat
        static int[] ConcatTwoArray(int[] arr1, int[] arr2)
        {
            int[] result = arr1.Concat(arr2).ToArray();

            return result;
        }

        //Сombine two arrays with Linq method Union without duplicates
        static int[] UnionTwoArray(int[] arr1, int[] arr2)
        {
            int[] result = arr1.Union(arr2).ToArray();

            return result;
        }

        //Сombine two arrays with Linq method CopyTo
        static int[] СombineTwoArray(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            arr1.CopyTo(result, 0);
            arr2.CopyTo(result, arr1.Length);

            return result;
        }

        //Сombine many arrays with Linq method SelectMany and params without duplicates 
        private static T[] Combine<T>(params IEnumerable<T>[] items) =>
                    items.SelectMany(i => i).Distinct().ToArray();

        //Сombine two arrays with List
        static int[] СombineTwoArrayWithList(int[] arr1, int[] arr2)
        {
            var result = new List<int>();
            result.AddRange(arr1);
            result.AddRange(arr2);

            return result.ToArray();
        }
       


    }
}
