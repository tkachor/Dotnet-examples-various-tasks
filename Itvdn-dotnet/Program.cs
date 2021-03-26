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

        // Array Sort 
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

        static void Main(string[] args) 
        {         
           
        }         
       
    }
}
