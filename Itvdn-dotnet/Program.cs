using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Itvdn_dotnet
{   
    
    class Program
    {
        //Array inversion with loop   
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

        //Array inversion with list
        static int[] InversionIntegerArrayWithList(int[] array)
        {
            List<int> list = array.ToList();
            list.Reverse();

            return list.ToArray();
        }

        static void Main(string[] args) 
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 89, 3 };


            foreach (var item in InversionIntegerArray(arr))
            {
                Console.Write(item);
            }

            Console.WriteLine();

            foreach (var item in InversionIntegerArrayWithList(arr))
            {
                Console.Write(item);
            }

         
           
        }         
       
    }
}
