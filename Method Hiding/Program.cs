using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{

    public class ParentClass
    {
        public string Firstname;
        

        public void PrintParentClass() //method
        {
            Console.WriteLine("This is calling from Parent Class");

        }
    }

    public class ChildClass : ParentClass
    {
        public new void PrintParentClass() //to just use the child class method that is same as parent class method, use the new in front of the return type

        {
            base.PrintParentClass();            //add this to unhide the parent class method.
            Console.WriteLine("This is calling from Child Class");
        }

        public void PrintAnotherChildClass()
        {
            Console.WriteLine("This is hiding the parent class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            ChildClass CC = new ChildClass();
            CC.PrintAnotherChildClass();
            Console.ReadLine();

            CC.PrintParentClass();
            Console.ReadLine();

            



        }
    }
}
