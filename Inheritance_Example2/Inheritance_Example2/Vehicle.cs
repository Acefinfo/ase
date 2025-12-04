using System;

namespace Inheritance_Example2
{
    internal class Vehicle
    {
        private string manufacturer;

        public Vehicle() { }

      
        public Vehicle(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { this.manufacturer = value; }
        }

        public string NameOf()
        {
            return "This vehicle is manufactured by " + manufacturer;
        }
    }
}
