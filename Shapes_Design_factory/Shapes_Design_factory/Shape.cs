using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_design_factory
{
    public abstract class Shape : Shapes
    {
        protected Color color;
        protected int x;
        protected int y;

        // Parameterless constructor. Initialize with default values i.e red color and (100,100) position
        public Shape()
        {
            color = Color.Red;
            x = y = 100;
        }

        // Paramaterized constructor. It initializes the color and position
        public Shape(Color color, int x, int y)
        {
            this.color = color;
            this.x = x;
            this.y = y;
        }

        // Abstract methods which will be implemented in the derived class. 
        public abstract void draw(Graphics g);
        public abstract double calcArea();
        public abstract double calcPerimeter();


        // This methord allows you to set color and position of the shape. 
        // Plus this method is cirtual so it can be overridden by the derived class.
        public virtual void set(Color color, params int[] list) { }

        public override string ToString()
        {
            return base.ToString() + "x:"+ this.x + " " + "y: "+ this.y;
        }
    }

}