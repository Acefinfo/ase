using ConsoleApp_Cicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example1_Circle
{
    internal class Rectangle: Shape
    {
        private double length;
        private double width;

        public Rectangle()
        {
        }
        public Rectangle(double length, double width): base()
        {
            this.length = length;
            this.width = width;
        }


    }
}
