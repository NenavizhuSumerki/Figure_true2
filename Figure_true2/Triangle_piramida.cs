﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_true
{
    class Triangle_piramida : Triangle
    {

        private double h;

        public Triangle_piramida(double a, double b, double c, double h) : base(a, b, c)
        {
            this.h = h;
        }

        private double lateralSurfaceArea()
        {
            double p = perimeter() / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // площадь боковой поверхности треугольника
            return (1.0 / 2) * perimeter() * h + s; // площадь основания + площадь боковой поверхности
        }

        private double volume()
        {
            return (1.0 / 3) * area() * h;
        }

        public override void Out()
        {
            Console.WriteLine($"Полная площадь поверхности пирамиды: {lateralSurfaceArea():f3}");
            Console.WriteLine($"Периметр основания пирамиды: {perimeter():f3}");
            Console.WriteLine($"Объем пирамиды: {volume():f3}");
        }

    }
}
