using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Itvdn_dotnet
{   
    class Auto
    {
        public string Name = "Clio";

        public void  PrintName()
        {
            Console.WriteLine(Name);
        }


    }
    
    class Program
    {        

        static void Main(string[] args) 
        {
            Auto auto1 = new Auto();

            auto1.Name = "Infinity";

            auto1.PrintName();
            
           
        }         
       
    }
}
