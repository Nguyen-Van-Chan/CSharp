using System;

namespace Polymorphism
{
    class Program
    {
        
        class Rectangle
        {
            public double Width { get; set; }
            public double Height { get; set; }        

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            // overload method
            public void Resize(double sameSize)
            {
                Width = sameSize;
                Height = sameSize;
            }
            public void Resize(int width, int height)
            {
                Width = width;
                Height = height;
            }
            public void Resize(double width, double height)
            {
                Width = width;
                Height = height;
            }

            // overload operator
            public static Rectangle operator +(Rectangle a, Rectangle b)
            {
                return new Rectangle(a.Width + b.Width, a.Height + b.Height);
            }
            public static Rectangle operator -(Rectangle a, Rectangle b)
            {
                return new Rectangle(a.Width - b.Width, a.Height - b.Height);
            }

            // other methods
            public double GetArea()
            {
                return Width * Height;
            }

            static void Main(string[] args)
            {

                Rectangle rectangle1 = new Rectangle(6.0, 7.0);
                Console.WriteLine("Area = {0} x {1} = {2}", rectangle1.Width, rectangle1.Height, rectangle1.GetArea());

                rectangle1.Resize(5.0);
                Console.WriteLine("Area = {0} x {1} = {2}", rectangle1.Width, rectangle1.Height, rectangle1.GetArea());

                Rectangle rectangle2 = new Rectangle(6.0, 4.0);

                // use operator +
                Rectangle rectangle3 = rectangle1 + rectangle2;
                Console.WriteLine("Area = {0} x {1} = {2}", rectangle3.Width, rectangle3.Height, rectangle3.GetArea());

                Console.ReadKey();
            }
        }
    }
}
