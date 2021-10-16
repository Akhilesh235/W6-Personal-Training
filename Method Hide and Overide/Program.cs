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

    public class DerivedClass1 : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am from Derived Class 1");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass BC = new DerivedClass1();
            BC.Print();
            Console.ReadLine();
        }
    }
}
