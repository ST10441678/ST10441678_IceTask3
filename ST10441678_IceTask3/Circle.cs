using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10441678_IceTask3
{
    class Circle : Shape, ICalculateArea
    {
        private int Radius;
        public Circle(string Name, int radius) : base(Name)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Display()
        {
            Console.WriteLine("\nShape: " + Name);
            Console.WriteLine("Radius: " + Radius);
            Console.WriteLine("Area: " + CalculateArea().ToString("F2"));

            Console.ReadLine();
        }

    }
}

