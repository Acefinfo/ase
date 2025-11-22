using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape myCircle = new Circle(5);
            Shape myRectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle Area: {myCircle.Area()}");
            Console.WriteLine($"Circle Perimeter: {myCircle.Perimeter()}");

            Console.WriteLine($"Rectangle Area: {myRectangle.Area()}");
            Console.WriteLine($"Rectangle Perimeter: {myRectangle.Perimeter()}");

            // Demonstrating polymorphism
            Shape[] shapes = { myCircle, myRectangle };
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
            }
        }
    }
}
