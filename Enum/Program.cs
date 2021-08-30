using System;

namespace Enum
{ 
    class Program
    {
        enum Operation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }

        static void MathOperation(double x, double y, Operation op)
        {
            double result = 0.0;

            switch (op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }

            Console.WriteLine($"Result of the operation is {result}");
        }


        static void Main(string[] args)
        {
            MathOperation(10, 5, Operation.Add);

            MathOperation(11, 5, Operation.Multiply);

            Console.ReadLine();

        }
    }
}
