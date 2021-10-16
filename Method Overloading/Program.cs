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
            Console.WriteLine("Input your first Number : ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your Second Number : ");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your Third Number : ");
            int k = int.Parse(Console.ReadLine());

            Add(i, j);
            Add(i, j, k);
            Console.ReadLine();
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum of first 2 numbers  = {0}" , FN+SN);

        }

        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum of three numbers = {0}", FN + SN+TN);

        }
    }
}
