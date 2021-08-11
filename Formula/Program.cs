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

        static double Circumference(double radius)
        {
            const double PI = 3.14;
            return Math.Round(2 * PI * radius);
        }

        static double AreaOfRectangle(double width, double height)
        {
            return width * height;
        }

        static double AreaOfSquare(double side1, double side2)
        {
            return side1 * side2;
        }

        static double AreaOfTriangle(double @base, double height)
        {
            return 0.5 * @base * height;
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return 1.8 * celsius +32;
        }





        static void Main(string[] args)
        {
            Console.WriteLine(AreaOfCircle(23));
            Console.WriteLine(Circumference(23));
        }
    }
}
