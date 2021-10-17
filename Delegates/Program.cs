using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void SampleDelegate();
    class Program
    {
        static void Main(string[] args)
        {

            SampleDelegate del1 = new SampleDelegate(SampleMethodOne);
            del1 += SampleMethodTwo;    // multi cast delegates
            del1 += SampleMethodThree;

            Console.ReadLine();
        }

        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample Method 1 Invoked");
        }

        public static void SampleMethodTwo()
        {
            Console.WriteLine("Sample Method 2 Invoked");
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("Sample Method 3 Invoked");
        }

    }

 
}
