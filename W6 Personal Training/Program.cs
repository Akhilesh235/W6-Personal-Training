using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6_Personal_Training
{
    class Circle
    {
        static float _PI = 3.141F;         //making pi static because the float value is constant
        int _Radius;

        public Circle(int Radius) // constructors
        {
            this._Radius = Radius;
        }

        public float CalculateArea()        // behaviour of your class
        {
            return Circle._PI * this._Radius * this._Radius;      // this keyword refers to an instance of a class. instance = non-static. Making a class member static means you cant use the this keyword
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            float Area1 = C1.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);

            Circle C2 = new Circle(6);
            float Area2 =C2.CalculateArea();
            Console.WriteLine("Area = {0}", Area2);
            Console.ReadLine();
        }
    }
}
