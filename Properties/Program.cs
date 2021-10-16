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

        public void SetName(string Name)
        {
            if(string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("name cannot be null or empty");
            }
            this._Name = Name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name) ? "no name" : this._Name;   //same as if else method

            //if (string.IsNullOrEmpty(_Name))
            //{
            //        return "no name";
            //}
            //else
            //{
            //        return this._Name;
            //}
        }

        public void SetId(int ID)
        {
            if(ID <= 0)
            {
                throw new Exception("invalid");
            }
            this._id = ID;
        }

        public int GetId()
        {
            return this._id;
        }

        public int GetPassMark()
        {
            return this._PassMark;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.SetId(101);
            C1.SetName("Mark");
            Console.WriteLine("Student ID = {0}", C1.GetId());
            Console.WriteLine("Student Name is {0}", C1.GetName());
            Console.WriteLine("Pass mark is {0}", C1.GetPassMark());
            Console.ReadLine();
        }
    }
}
