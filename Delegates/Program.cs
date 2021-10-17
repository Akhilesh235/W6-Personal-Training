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

            SampleDelegate del1, del2, del3, del4;

            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);

            del4 = del1 + del2 + del3;
            del4(); // del 4 is the multi cast delegate
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
