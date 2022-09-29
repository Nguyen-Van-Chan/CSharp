using System;

namespace Class
{
    class Box
    {
        // fields
        //private double _length;
        //private double _breadth;
        //private double _height;

        // properties
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Height { get; set; }

        // default constructor
        public Box()
        { }

        // constructor with parameters
        public Box(double length, double breadth, double height)
        {
            Length = length;
            Breadth = breadth;
            Height = height;
        }

        // method
        public void Print()
        {
            Console.WriteLine("Length = {0}, Breadth = {1}, Height = {2}", Length, Breadth, Height);
        }
    }

    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
    //derived class
    class Progam2 : Shape
    {
        public int getArea()
        {
            return Width * Height;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Box _box1 = new Box(2, 4, 6);
            _box1.Print();

            Progam2 Inheritence = new Progam2();
            Inheritence.Width = 2;
            Inheritence.Height = 4;
            Console.WriteLine("Area: {0}", Inheritence.getArea());


            Console.ReadKey();
        }
    }
}
