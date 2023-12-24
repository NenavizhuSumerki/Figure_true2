using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_true
{
    class Rectangle
    {
        protected double a;
        protected double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        protected double peri()
        { return ((a + b) * 2); }

        protected double area()
        { return (a * b); }

        public virtual void Out()
        {
            Console.WriteLine("Прямоугольник со сторонами " + a + "и " + b);
            Console.WriteLine($"Площадь: {area():f3}");
            Console.WriteLine($"Периметр:  {peri():f3}");
        }
    }
}
