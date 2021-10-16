using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(5, 10);
            Add(5, 10,100);
            Add(5, 7.2F);
            
            Console.ReadLine();
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum of first 2 numbers  = {0}" , FN+SN);

        }

        public static void Add(int FN, int SN, int TN) // method can be overloaded on number of parameters
        {
            Console.WriteLine("Sum of three numbers = {0}", FN + SN+TN);

        }

        public static void Add(int FN, float SN)    // method can be overloaded on type of parameters
        {
            Console.WriteLine("Sum of int and float numbers  = {0}", FN + SN);

        }

        public static void Add(int FN, int SN, out int Sum) // method can be overloaded on kind of parameters --> int is a value parameter // out is an output parameter
        {
            Console.WriteLine("This is overloading through different kind of parameter", Sum = FN + SN);

        }


    }
}
