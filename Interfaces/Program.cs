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
        public void InterfaceMethod()   
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
            p.InterfaceMethod();
            ((I2)P).InterfaceMethod();
           
            Console.ReadLine();
        }
    }
}
