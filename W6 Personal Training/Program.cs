using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6_Personal_Training
{
    class Circle
    {
        float _PI = 3.141F;         //state of your class
        int _Radius;

        public Circle(int Radius)
        {
            this._Radius = Radius;
        }

        public float CalculateArea()        // behaviour of your class
        {
            return this._PI * this._Radius * this._Radius;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            float Area -C1.CalculateArea();
            Console.WriteLine("Area = {0}" , Area);
            Console.ReadLine();
        }
    }
}
