using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void HelloFunctionDelegate(string Message);     // 1) Create delegate
    class Program
    {
        static void Main(string[] args)
        {
            // A delegate is a type safe function pointer

            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello); // 2) Create instance of delegate and in the constructor(paranthesis) call the method
            del("Hello from Delegate"); // 3) Invoke the delegate so that it invokes the method
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
            Console.ReadLine();
        }
    }
}
