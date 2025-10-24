using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_24._10._25_
{
    internal class Rectangle : Shape
    {
        

        public double length;
        public double width;
        public double area;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override void CalculateArea()
        {
            area = length * width;
            Console.WriteLine($"Area of Rectangle: {area}");
        }
    }
}
