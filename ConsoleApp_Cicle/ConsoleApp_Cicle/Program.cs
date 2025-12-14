using System;


namespace ConsoleApp_Cicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(10, 20, 30.0);
            Console.WriteLine("Circle1 - X: {0}, Y: {1}", circle1.X, circle1.Y);
            Circle circle2 = new Circle();
            circle2.setData(40, 50, 60.0);
            Console.WriteLine("Circle2 - X: {0}, Y: {1}", circle2.X, circle2.Y);
        }
    }
    
}