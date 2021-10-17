using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int SampleDelegate();
    class Program
    {
        static void Main(string[] args)
        {

            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;    // multi cast delegates

            int DelegateReturnedValue = del();
           

            Console.WriteLine(DelegateReturnedValue);
            Console.ReadLine();
        }

        public static int  SampleMethodOne()
        {
            return 1;
        }

        public static int SampleMethodTwo()
        {
            return 2;
        }

    }

 
}
