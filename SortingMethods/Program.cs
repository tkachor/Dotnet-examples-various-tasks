using System;

namespace SortingMethods
{
    
    class Program
    {
        //Bubble Sort
        static void BubbleSortInteger(int[] array)
        {
            int temp = 0;

            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;

                    }
                }
            }           
        }

        //Insertion Sort
        static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }




        static void Main(string[] args)
        {
            Random random = new Random();
            int arrauLength = 100;
            int[] array = new int[arrauLength];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(arrauLength);
                Console.WriteLine(array[i]);
            }

            InsertionSort(array);
            //BubbleSortInteger(array);

            Console.WriteLine("-------------------");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
