using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Association
{
    class Product
    {
        public Product()
        {
            Console.WriteLine("Fabric method");
        }
    }

    class Factory
    {
        public Product FactoryMethod()
        {
            return new Product();
        }
    }

    class Association
    {
        static void Main()
        {
            Factory factory = new Factory();

            Product product = factory.FactoryMethod();

        }
    }
}
