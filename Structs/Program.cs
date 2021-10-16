using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Customer
    {
        private int _id { get; set; }
        private string _name { get; set; }
      
        public Customer (int ID, string Name)   // constructor for structure
        {
            _id = ID;
            _name = Name;
        }

        public void PrintDetails()      // method
        {
            Console.WriteLine("Id = {0} && Name = {1}" , _id,_name);
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Key your ID");
            int CustomerID = int.Parse(Console.ReadLine());
            Console.WriteLine("Key your Name");
            string CustomerName = Console.ReadLine();

            Customer C1 = new Customer(CustomerID, CustomerName);   //creating instance of constructor
            C1.PrintDetails();

            
            
            Console.ReadLine();
        }
    }
}
