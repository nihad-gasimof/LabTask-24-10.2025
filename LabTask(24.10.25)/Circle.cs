using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_24._10._25_
{
    internal class Circle : Shape
    {
        public double _radius ;
        public double area;
        public Circle(double radius)
        {
            _radius = radius;
        }

        public override void CalculateArea()
        {
            area = (double)Math.PI * _radius *_radius;
            Console.WriteLine($"Circle area is :{area}");
        }
    }
}
