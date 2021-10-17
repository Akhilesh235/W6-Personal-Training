using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public abstract class Customer
    {
        public abstract void Print();   // only declaration.. no implementation for abstract methods

        
    }
    
    class Program : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print method");
        }
        static void Main(string[] args)
        {
            Customer C = new Program();
            C.Print();
            Console.ReadLine();
        }
    }
}
