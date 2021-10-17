using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomer1
    {
        void Print1(); // interface only allows declaration     
        //{
        //    Console.WriteLine("Hello"); // interface does not allow implementation
        //}
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }

    class Customer: ICustomer2   // class can inherit from multiple Interfaces at the same time
    {
        public void Print2()
        {
            Console.WriteLine("Print2"); ;
        }

        public void Print1()
        {
            Console.WriteLine("Print1");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Print1();
            C1.Print2();
         
            Console.ReadLine();
        }
    }
}
