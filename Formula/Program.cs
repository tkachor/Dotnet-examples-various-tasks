using System;

namespace Formula
{


    class Program
    {
        static double AreaOfCircle(double radius)
        {
            const double PI = 3.14;
            return Math.Round(PI * Math.Pow(radius, 2), 2);
        }

        static double CircumFerence(double radius)
        {
            const double PI = 3.14;
            return Math.Round(2 * PI * radius);
        }


        static void Main(string[] args)
        {
            Console.WriteLine(AreaOfCircle(23));
            Console.WriteLine(CircumFerence(23));
        }
    }
}
