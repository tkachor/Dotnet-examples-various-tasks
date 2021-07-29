using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Inheritance
{
    class Basic
    {
        public string publicField = "BaseClass.publicField";
        private string privateField = "BaseClass.privateField";
        protected string protectedField = "BaseClass.protectedField";
       

        public void Show()
        {
            Console.WriteLine(privateField);
        }
    }
}
