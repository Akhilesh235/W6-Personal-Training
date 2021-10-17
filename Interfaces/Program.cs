using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2    // both Interfaces have the same declaration
    {
        void InterfaceMethod();
    }



    class Program : I1, I2
    {
        void I1.InterfaceMethod()   // Explicitly state which interface its calling from
        {
            Console.WriteLine("I1 Interface method");
        }

        void I2.InterfaceMethod()
        { 
            Console.WriteLine("I1 Interface method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            ((I1)p).InterfaceMethod();      // use type casting to invoke the I1 method
            ((I2)p).InterfaceMethod();      // you still wont know which Interface is being called --> See next git change
            
            I1 i1 = new Program();      // another way
            I2 i2 = new Program();
            i1.InterfaceMethod();
            i2.InterfaceMethod();
            
            Console.ReadLine();
        }
    }
}
