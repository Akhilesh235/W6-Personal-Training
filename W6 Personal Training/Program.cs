using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6_Personal_Training
{
    class Circle
    {
        public static float _PI = 3.141F;         //making pi static because the float value is constant
        int _Radius;                       // this is an instance field --> to initialize an instance field, you use an instance constructor

        //static int _radius;               // this is a static field--> use static constructor to initialize it

        static Circle()                     // you cant use access modifier on a static Constructor
        {
            Console.WriteLine("Static Constructor Called");
            Circle._PI = 3.141F;
        }
        
        public Circle(int Radius)           // instance constructors --> they are called AFTER static constructors
        {
            Console.WriteLine("Instance Constructor called");
            this._Radius = Radius;
        }

        //public static void Print()
        //{

        //}

        public float CalculateArea()        // behaviour of your class
        {
            return Circle._PI * this._Radius * this._Radius;      // this keyword refers to an instance of a class. instance = non-static. Making a class member static means you cant use the this keyword
        }
    }

    /*
     Inheritence Syntax
    public class ParentClass
    {
        Parent Class Implementation
    }

    public class DerivedClass : ParentClass
    {
        Derived Class Implementation
    } 
     */

    public class ChildClass:ParentClass
    {
        public ChildClass() : base("Derived Class controlling Parent Class")
        {
            Console.WriteLine("Child class constructor called next");
        }
    }
    
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Class Constructor called first ");
        }

        public ParentClass(string Message)
        {
            Console.WriteLine(Message);
        }
    }

    public class Employee
    {
        public string firstname;
        public string lastname;
        public string email;

        public void PrintFullName()
        {
            Console.WriteLine(firstname + lastname);
        }
    }

    public class FullTimeEmployee : Employee //inheritence
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass CC = new ChildClass();   // even though u called the childclass, the parent class constructor is called first then the child class constructor is called
            
            //FullTimeEmployee FTE = new FullTimeEmployee();
            //FTE.firstname = "akhilesh ";
            //FTE.lastname = "dayal";
            //FTE.email = "akhilesh.dayal@whoohoo.com";
            //FTE.PrintFullName();

            //PartTimeEmployee PTE = new PartTimeEmployee();
            //PTE.firstname = "askjhd";
            //PTE.lastname = "dayal";
            //PTE.email = "akhilesh.dayal@whoohoo.com";
            //PTE.HourlyRate = 100;
            //PTE.PrintFullName();


            //Console.WriteLine(Circle._PI);
            //    Circle C1 = new Circle(5);      // creating an instance of the class
            //    float Area1 = C1.CalculateArea();
            //    //C1.Print();       since the Print method is a static method, you cant call it using the instance of a class.
            //    //Circle.Print();     // you have to call the static method, through the name of the class
            //    Console.WriteLine("Area = {0}", Area1);

            //    Circle C2 = new Circle(6);
            //    float Area2 =C2.CalculateArea();
            //    Console.WriteLine("Area = {0}", Area2);
            Console.ReadLine();
        }
    }
}
