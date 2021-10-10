using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6_Personal_Training
{
    class Customer
    {
        string _firstName;  //creating string object
        string _lastName;

        public Customer(string FirstName, string LastName)  //constructor --> to initialize class field
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public void PrintFullName() //method 
        {
            Console.WriteLine("Full name : {0}" , this._firstName + " " + this._lastName);
        }
        ~Customer()
        {
            // clean up code goes here
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Akhilesh", "Dayal"); // creating instance (aka OBJECT) of the class
            customer.PrintFullName();
            Console.ReadLine();
        }
    }
}
