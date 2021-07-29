using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Inheritance
{
    class Derived : Basic
    {        
        public Derived()
        {
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";
        }
    }
}
