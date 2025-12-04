// See https://aka.ms/new-console-template for more information
using Inheritance_Example2;

public class Program
{
    public static void Main(string[] args)
    {
        Inheritance_Example2.Car myCar = new Inheritance_Example2.Car("Toyota", "Sedan");
        Console.WriteLine(myCar.NameOf());
        Console.WriteLine(((Vehicle)myCar).NameOf());
        Console.WriteLine();

        Car c = new Car("Honda", "SUV");
        Console.WriteLine(c.NameOf());

    }
}
