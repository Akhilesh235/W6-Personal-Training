using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";
        public virtual void PrintEmployeeName()
        {
            Console.WriteLine("Full name of Employee is : " + FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintEmployeeName()
        {
            Console.WriteLine("Full name of Part time Employee is : " + FirstName + " " + LastName + " - Part Time");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintEmployeeName()
        {
            Console.WriteLine("Full name of Part time Employee is : " + FirstName + " " + LastName + " - Full Time");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public void PrintEmployeeName()
        {
            Console.WriteLine("Full name of Part time Employee is : " + FirstName + " " + LastName + " - Temporary");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4]; //creating employee array

            employees[0] = new Employee();      // employees is a base class reference variable
            employees[1] = new PartTimeEmployee();  //base class reference variable can point to a Child Class object --> you can assign a Child Class Object to a base class reference variable
            employees[2] = new FullTimeEmployee(); // because you add OVERRIDE, the Child Class method will be called
            employees[3] = new TemporaryEmployee(); // since there is no Override for the method, it will just call the method from the Parent Class

            foreach (Employee e in employees)
            {
                e.PrintEmployeeName();
                
                
            }
            Console.ReadLine();
        }
    }
}
