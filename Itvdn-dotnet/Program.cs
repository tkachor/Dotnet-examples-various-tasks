using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Itvdn_dotnet
{
    

    class Program
    {

       
        public static void PrintRhombusInMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            int midSize = size/2;

            for (int i = 0; i < size; i++)
            {
                if (i < midSize)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (j < midSize + i && j < midSize - i)
                        {
                            matrix[i, j] = 1;
                        }
                        else if (j > midSize + i && j > midSize - i)
                        {
                            matrix[i, j] = 2;
                        }
                        else
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }               
                else
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (j <= midSize - (size - i) && j <= midSize + (size - i))
                        {
                            matrix[i, j] = 3;
                        }
                        else if (j >= midSize - (size - i) && j >= midSize + (size - i))
                        {
                            matrix[i, j] = 4;
                        }
                        else
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }            
        }       



        static void Main()
        {

            PrintRhombusInMatrix(3);




        }
    }
}
