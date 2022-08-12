using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Enum
{
    class Program
    {

        static void Main(string[] args)
        {

            static int[] CountBy(int x, int n)
            {

                List<int> rezult = new List<int>(n);


                for (int i = 1; i < rezult.Count; i++)
                {
                    if (i % x == 0)
                    {
                        rezult.Add(i);
                    }
                }

                return rezult.ToArray();
            }



        }
       
    }
}
