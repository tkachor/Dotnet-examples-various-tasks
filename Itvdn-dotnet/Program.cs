using System;
using System.Collections.Generic;
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

        //array[0] ---> represents $1 bills

        //array[1] ---> represents $5 bills

        //array[2] ---> represents $10 bills

        //array[3] ---> represents $20 bills

        //array[4] ---> represents $50 bills

        //array[5] ---> represents $100 bills

        //giveChange(365) // =>  [0,1,1,0,1,3]

        public static int[] GiveChange(int amount)
        {
            int count = amount;

            int bills_100 = (int)count / 100;

            int bills_50 = (int)(count - bills_100) / 50;

            int bills_20 = (int)(count - bills_50) / 20;

            int bills_10 = (int)(count - bills_20) / 10;

            int bills_5 = (int)(count - bills_10) / 5;

            int bills_1 = (int)(count - bills_5);

            return new int [] { bills_1, bills_5, bills_10, bills_20, bills_50, bills_100 };
        }

        static void Main()
        {
            foreach (var item in GiveChange(365))
            {
                Console.WriteLine(item);
            }
        }
    }
}
