using System;

namespace getset
{
    public class Drawing
    {
        public virtual double Area()
        {
            return 654.564;
        }
    }

    public class Circle : Drawing
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 5;
        }
        public override double Area()
        {
            return (3.14) * Math.Pow(Radius, 2);
        }
    }

    public class Sqaure : Drawing
    {
        public double Length { get; set; }
        public Sqaure()
        {
            Length = 6;
        }
        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }

    public class Rectangle : Drawing
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle()
        {
        }
        public Rectangle(int Width, int Height)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public override double Area()
        {
            return Height * Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Drawing circle = new Circle();
           // circle.
            Console.WriteLine("Area of circle: " + circle.Area());

            Drawing square = new Sqaure();
            Console.WriteLine("Area of square: " + square.Area());

            Drawing rectangle = new Rectangle();
            Console.WriteLine("Area of rectangle: " + rectangle.Area());



            Rectangle rec = new Rectangle();
            //rec.Width = 5;
            //rec.Height = 8;
            Console.WriteLine(rec.Width);
            Console.WriteLine("Area of rectangle: " + rec.Area());
        }
    }
}
