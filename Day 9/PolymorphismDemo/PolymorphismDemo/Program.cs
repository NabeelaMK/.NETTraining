using System;
namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            s1.DrawShape();      //Shape
            Circle c2 = new Circle();
            c2.DrawShape();      //Circle
            Rectangle r3 = new Rectangle();
            r3.DrawShape();      //Rectangle

            //After doing inheritance

            Shape s2 = new Circle(); //Upcasting
            s2.DrawShape();     //Circle
            Shape s3 = new Rectangle(); //Upcasting
            s3.DrawShape();     //Rectangle

            //Array of refernces of base class referncing derived class
            //object (UPCASTING)

            Shape[] p =
            {
                new Circle(),
                new Rectangle(),
                new Circle(),
                new Rectangle(),
                new Circle()
            };
            for( int i = 0; i < p.Length; i++ ) 
            {
                p[i].DrawShape();
            }

            Shape t = null;
            Console.WriteLine("Enter Shape: ");
            string Shape=Console.ReadLine();
            if( Shape.ToLower( ) == "circle")
                t= new Circle();
            else if( Shape.ToLower( ) == "rectangle")
                t= new Rectangle();
            t.DrawShape();

        }
    }
}
