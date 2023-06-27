using System;

namespace ShapeAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure1 = new Circle(3.2);
            var figure2 = new Square(6.5);
            var figure3 = new Triangle(3, 4, 5);

            Console.WriteLine(figure1.GetSquare());
            Console.WriteLine(figure2.GetSquare());
            Console.WriteLine(figure3.GetSquare());
        }
    }
}
