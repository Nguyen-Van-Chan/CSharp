using System;

namespace Polymorphism_Overriding
{
    class Program
    {
        abstract class Shape
        {
            public abstract int GetArea();
        }

        class Rectangle : Shape
        {
            public int Weight { get; set; }
            public int Height { get; set; }
            public Rectangle(int weight, int height)
            {
                Weight = weight;
                Height = height;
            }
            public override int GetArea()
            {
                return Weight * Height;
            }

        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 6);
            Console.WriteLine(rectangle.GetArea());
            Console.ReadKey();

        }
    }
}
