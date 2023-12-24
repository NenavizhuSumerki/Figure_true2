using System.Drawing;
using System.Runtime.CompilerServices;

namespace Figure_true
{
    class Program
    {

        static void Main()
        {

            while (true)
            {
                Console.WriteLine("\nВыберите, какую фигуру будем считать: \n1 - Квадрат\n2 - Прямоугольник\n3 -  Круг\n4 - Треугольник\n5 - Пирамида");

                int Dejstvie = int.Parse(Console.ReadLine());
                Console.Clear();
                if (Dejstvie == 1)
                {
                    Console.Write("Введите сторону квадрата: ");
                    double a = double.Parse(Console.ReadLine());
                    Square square = new Square(a);
                    Console.Clear();
                    square.Out();
                    Console.WriteLine();
                }
                if (Dejstvie == 2)
                {
                    Console.Write("Введите ширину прямоугольника: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Введите длину прямоугольника: ");
                    double b = double.Parse(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(a, b);
                    Console.Clear();
                    rectangle.Out();
                    Console.WriteLine();

                }
                if (Dejstvie == 3)
                {
                    Console.Write("Введите радиус круга: ");
                    double a = double.Parse(Console.ReadLine());
                    Circle circle = new Circle(a);
                    Console.Clear();
                    circle.Out();
                    Console.WriteLine();
                }
                if (Dejstvie == 4)
                {
                    Console.WriteLine("Сумма двух сторон должна быть больше третьей!");
                    Console.Write("Введите сторону А: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Введите сторону B: ");
                    double b = double.Parse(Console.ReadLine());


                    Console.Write("Введите сторону C: ");
                    double c = double.Parse(Console.ReadLine());

                    Triangle triangle = new Triangle(a, b, c);
                    Console.Clear();
                    triangle.Out();
                    Console.WriteLine();
                }
                if (Dejstvie == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Введите, какую пирамиду вы хотите посчитать.");
                    Console.WriteLine("1 - Конус\n2 - Квадратная пирамида \n3 - Треугольная пирамида \n \n");
                    Console.Write("Выбери основание: ");
                    int dejstvie = int.Parse(Console.ReadLine());



                    if (dejstvie == 1)
                    {


                        Console.Write("Введите радиус круга основания конуса: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Введите высоту конуса: ");
                        double h = double.Parse(Console.ReadLine());

                        Conus pyramid = new Conus(a, h);

                        pyramid.Out();
                        Console.WriteLine();
                    }
                    if (dejstvie == 2)
                    {


                        Console.Write("Введите сторону квадрата для основания пирамидки: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Введите высоту: ");
                        double h = double.Parse(Console.ReadLine());

                        Piramida pyramid = new Piramida(a, h);

                        pyramid.Out();
                        Console.WriteLine();
                    }
                    if (dejstvie == 3)
                    {
                        Console.WriteLine("Сумма двух сторон должна быть больше третьей!");

                        Console.Write("Введите сторону A: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Введите сторону B: ");
                        double b = double.Parse(Console.ReadLine());

                        Console.Write("Введите сторону C: ");
                        double c = double.Parse(Console.ReadLine());

                        Console.Write("Введите высоту: ");
                        double h = double.Parse(Console.ReadLine());

                        Triangle_piramida pyramid = new Triangle_piramida(a, b, c, h);

                        pyramid.Out();
                        Console.WriteLine();
                    }

                }
            }
        }













    }
}