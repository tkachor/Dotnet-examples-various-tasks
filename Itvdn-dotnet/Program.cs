using System;

namespace Itvdn_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,,,] array =

 {

    {

        {

            { 0, 1, 2 },

            { 2, 3, 4 },

            { 5, 6, 7 }

        },

        {

            { 8, 9, 10 },

            { 11, 12, 13 },

            { 14, 15, 16 }

        }

    }

};

            for (int i = 0; i < array.GetLength(3); i++)

                Console.Write(array[0, 0, 1, i]);
        }
    }
}
