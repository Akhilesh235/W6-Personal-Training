using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hide_and_Overide
{
    public class BaseClass
    {
        public virtual void Print()
        { 
            Console.WriteLine("I am from Base Class"); 
        }
    }

    public class DerivedClass : BaseClass
    {
        //public override void Print()     // override keyword will invoke the overriden method in Child Class
        //{
        //    Console.WriteLine("I am from Derived Class 1");
        //}

        public new void Print()     // new keyword will invoke the hidden method in Base Class
        {
            Console.WriteLine("I am from Derived Class");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass BC = new DerivedClass();
            BC.Print();
            Console.ReadLine();
        }
    }
}
