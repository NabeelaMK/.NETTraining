using System;
namespace AbsClassAreaPeri
{
    abstract class Figure
    {
        public int Dimension;
        public abstract double Area();
        public abstract double perimeter();
    }
    class Square: Figure
    {
        public override double Area()
        {
            return Dimension*Dimension;
        }
        public override double perimeter() 
        {
        return 4*Dimension;
        }
    }
    class Circle: Figure
    {
        public override double Area()
        {
            return Math.PI*Dimension*Dimension;
        }
        public override double perimeter()
        {
            return 2*Math.PI*Dimension;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Square();
            figure.Dimension = 10;
            Console.WriteLine("*****SQUARE*****");
            Console.WriteLine(figure.Area());
            Console.WriteLine(figure.perimeter());

            Figure figure1= new Circle();
            figure1.Dimension = 10;
            Console.WriteLine("*****CIRCLE*****");
            Console.WriteLine(figure1.Area());
            Console.WriteLine(figure1.perimeter());






        }
    }
}
