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



    class Program : I1,I2
    {
        public void InterfaceMethod()   //both interfaces are inherited by 1 class, and it is unable to know which one to call
        {
            Console.WriteLine("I1 Interface method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            ((I1)p).InterfaceMethod();      // use type casting to invoke the I1 method
            ((I2)p).InterfaceMethod();      // you still wont know which Interface is being called --> See next git change
            Console.ReadLine();
        }
    }
}
