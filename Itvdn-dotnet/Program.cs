using System;using System.Numerics;

namespace Itvdn_dotnet
{   
    
    class Program
    {
        static bool IsPrimeNumber(int number)
        {
            bool result = true;

            if (number > 1)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
        static void Main(string[] args) 
        {
            Console.WriteLine(IsPrimeNumber(22));
        }         
       
    }
}
