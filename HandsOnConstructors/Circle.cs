using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructors
{
    class Circle
    {
        public double radius;
        static double PI;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        static Circle()
        {
            Console.WriteLine("Iam invoked only once");
            PI = 3.14;
        }
        public double Area()
        {
            double result;
            result = PI * radius * radius;
            return result;
        }
    }
    class Circle_Test
    {
        static void Main()
        {
            Circle[] c= new Circle[4];
            c[0] = new Circle(10);
            c[1] = new Circle(5);
            c[2] = new Circle(2);
            c[3] = new Circle(12);
            foreach (var i in c)
                Console.WriteLine("Area of  circle  with radius {0} is :{1}", i.radius, i.Area());



        }
    }
}
