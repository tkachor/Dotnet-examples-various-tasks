using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Itvdn_dotnet
{   
    
    class Program
    {

        static int CountOfWords(string text)
        {
            int counterWords = 0;

            foreach (var item in text.Split(' '))
            {
                counterWords++;
            }

            return counterWords;

        }

        static void Main(string[] args) 
        {

            string str = "Tesds dsadas sadsa, sdsad";

            Console.WriteLine(CountOfWords(str));
           
        }         
       
    }
}
