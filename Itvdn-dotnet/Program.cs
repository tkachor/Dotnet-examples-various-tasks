using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Itvdn_dotnet
{

   

    class Program
    {
        static void Main()
        {

            string countDays(DateTime d)
            {
                DateTime today = DateTime.Now;

                if ((d - today).Days == 0)
                {
                    return "Today is the day!";
                }
                else if ((d - today).Days < 0)
                {
                    return "The day is in the past!";
                }
                else(today.Day < d.Day)
                {
                    return $"{(d - today).Days} days";
                }               
            }


            Console.WriteLine(countDays(new DateTime(2022, 09, 3)));
        }
    }
}
