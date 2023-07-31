using System;

namespace ClassDemo4
{
    interface Shape
    {
        double GetPerimeter();
        double GetArea();
    }

    class Circle : Shape
    {
        public double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public double GetPerimeter()
        {
            return 2 * radius * 3.14;
        }

        public double GetArea()
        {
            return 3.14 * radius * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10.0);
            Console.WriteLine(c.GetPerimeter());
            Console.WriteLine(c.GetArea());
        }
    }
}

namespace NewDemo
{
    class Demo;
    {
        public int DemoField;
        public Demo(int n)
        {
            DemoField = n;
        }
    }
}