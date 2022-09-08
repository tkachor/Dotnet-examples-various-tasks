using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Itvdn_dotnet
{

   

    class Program
    {
        enum Color
        {
            Red,
            Blue,
            Grean
        }


        static void Main()
        {
            Console.WriteLine("Main Starts");
            // создаем задачу
            Task task1 = new Task(() =>
            {
                Console.WriteLine("Task - 1 Starts");
                Thread.Sleep(1000);
                Console.WriteLine("Task - 1 Ends");
            });

            Task task2 = new Task(() =>
            {
                Console.WriteLine("Task - 2 Starts");
                Thread.Sleep(1000);
                Console.WriteLine("Task - 2 Ends");
            });

            Task task3 = new Task(() =>
            {
                Console.WriteLine("Task - 3 Starts");
                Thread.Sleep(1000);
                Console.WriteLine("Task - 3 Ends");
            });


            task1.RunSynchronously();
            task2.RunSynchronously();
            task3.RunSynchronously();
        
            Console.WriteLine("Main Ends"); // этот вызов ждет завершения задачи task1 

        }
    }
}
