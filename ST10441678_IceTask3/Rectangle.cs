using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10441678_IceTask3
{
    class Rectangle : Shape, ICalculateArea
    {
        private int Width;
        private int Height;
        public Rectangle(string Name, int width, int height) : base(Name)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public override void Display()
        {
            Console.WriteLine("Shape: " + Name);
            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Area: " + CalculateArea());
        }
    }
}
