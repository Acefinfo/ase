using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return radius * radius * Math.PI;
        }

        public override double Perimeter()
        {
            return 2.0 * Math.PI * radius;
        }

       
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
    }
}


