using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void SampleDelegate(out int Integer);
    class Program
    {
        static void Main(string[] args)
        {

            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;    // multi cast delegates

            int DelegateOutputParameterValue = -1;
            del(out DelegateOutputParameterValue);
           

            Console.WriteLine(DelegateOutputParameterValue);
            Console.ReadLine();
        }

        public static void  SampleMethodOne(out int Number)
        {
            Number = 1;
        }

        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }

    }

 
}
