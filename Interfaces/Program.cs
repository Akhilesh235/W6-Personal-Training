using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomer
    {
        void Print(); // interface only allows declaration     
        //{
        //    Console.WriteLine("Hello"); // interface does not allow implementation
        //}
    }

    interface I2
    {
        void I2Method();
    }

    class Class2 : ICustomer, I2    // class can inherit from multiple Interfaces at the same time
    {
        public void I2Method()
        {
            Console.WriteLine("I2 Method Printed from Class 2"); ;
        }

        public void Print()
        {
            Console.WriteLine("Interface Printed from Class 2");
        }
    }

    class Customer : ICustomer
    {
        public void Print()     //Signature of the Declaration should be the same as the Interface
        {
            Console.WriteLine("Interface Print Method");    //Implementation for the Interface
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Print();

            Class2 C2 = new Class2();
            C2.Print();
            C2.I2Method();
            Console.ReadLine();
        }
    }
}
