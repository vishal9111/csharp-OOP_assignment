using System;

namespace ConsoleApp1
{
    class Circle
    {
        double radius;

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double Getradius()
        {
            return radius;
        }
        public double calcdia()
        {
            return 2 * radius;
        }
        public double calcarea()
        {
            return Math.PI * radius * radius;
        }
    }


    class CircleTest
    {
        static void Main ()
        {
            Circle c1 = new Circle();
            c1.SetRadius(5);
            Console.WriteLine(c1.Getradius());
            Console.WriteLine(c1.calcdia());
            Console.WriteLine(c1.calcarea());
        }
    }
}
