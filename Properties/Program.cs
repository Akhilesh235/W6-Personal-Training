using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _PassMark =35;

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name cannot be null or empty");
                }
                this._Name = value;
            }

            get
            {
                return string.IsNullOrEmpty(this._Name) ? "no name" : this._Name;
            }
        }

        public int ID
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("invalid");
                }
                this._id = value;
            }

            get
            {
                return this._id;
            }
            
        }

        public int PassMark 
        { 
            get
            {
                return this._PassMark;
            }
        }
        
           
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.ID = 101;    // you are setting the value here. 101 will be passed to set method 
            Console.WriteLine("Student ID = {0}", C1.ID);       //you are getting the value of ID that has been set and passed

            C1.Name = "Mark";    // set name
            Console.WriteLine("Student Name is {0}", C1.Name); //get name

            Console.WriteLine("Pass mark is {0}", C1.PassMark); // only getting the value
            Console.ReadLine();
        }
    }
}
