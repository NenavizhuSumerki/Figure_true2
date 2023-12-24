using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_true
{
    class Circle
    {
        protected double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        protected double perimeter()
        { return (2 * 3.14 * radius); }

        protected double area()
        { return (3.14 * (radius * radius)); }

        public virtual void Out()
        {

            Console.WriteLine($"Площадь круга: {area():f3}");
            Console.WriteLine($"Периметр круга: {perimeter():f3}");
        }
    }
}

