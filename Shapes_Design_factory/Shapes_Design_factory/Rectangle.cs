using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shapes_design_factory
{
    internal class Rectangle : Shape
    {
        int width, height;

        // Parameterless constructor
        public Rectangle() : base()
        {
            width = 100;  // Default width
            height = 100; // Default height
        }

        // Parameterized constructor to initialize a Rectangle with color, position, width, and height
        public Rectangle(Color color, int x, int y, int width, int height) : base(color, x, y)
        {
            this.width = width;
            this.height = height;
        }

        // Overriding the set method to set the position, color, width, and height
        public override void set(Color color, params int[] list)
        {
            // list[0] is x, list[1] is y, list[2] is width, list[3] is height
            base.set(color, list[0], list[1]);  // Set color and position using the base method
            this.width = list[2];   // Set width
            this.height = list[3];  // Set height
        }

        // Draw method to render the rectangle on a graphics object
        public override void draw(Graphics g)
        {
            Pen p = new Pen(this.color, 2);  // Outline color with width 2
            SolidBrush b = new SolidBrush(this.color);  // Fill color
            g.FillRectangle(b, x, y, width, height);  // Draw filled rectangle
            g.DrawRectangle(p, x, y, width, height);  // Draw rectangle outline
        }

        // Calculate area of the rectangle (width * height)
        public override double calcArea()
        {
            return width * height;
        }

        // Calculate perimeter of the rectangle (2 * (width + height))
        public override double calcPerimeter()
        {
            return 2 * (width + height);  // Perimeter of rectangle
        }
    }
}
