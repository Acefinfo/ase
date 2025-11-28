using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_design_factory
{
    public class Triangle : Shape
    {
        int baseLength, height;

        // Parameterless constructor
        public Triangle() : base()
        {
            baseLength = 100;  // Default base length
            height = 100;      // Default height
        }

        // Parameterized constructor to initialize a Triangle with color, position, base, and height
        public Triangle(Color color, int x, int y, int baseLength, int height) : base(color, x, y)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        // Override the set method to set the position, color, base, and height
        public override void set(Color color, params int[] list)
        {
            // list[0] is x, list[1] is y, list[2] is baseLength, list[3] is height
            base.set(color, list[0], list[1]);  // Set color and position using the base method
            this.baseLength = list[2];   // Set base length
            this.height = list[3];       // Set height
        }

        // Draw method to render the triangle on a graphics object
        public override void draw(Graphics g)
        {
            // Define the points for the triangle (isosceles triangle)
            Point[] points = new Point[]
            {
                new Point(x, y),  // Bottom-left corner
                new Point(x + baseLength, y),  // Bottom-right corner
                new Point(x + baseLength / 2, y - height)  // Top-center point
            };

            // Create a Pen and Brush with the shape's color
            Pen p = new Pen(this.color, 2);  // Outline color with width 2
            SolidBrush b = new SolidBrush(this.color);  // Fill color

            // Fill the triangle
            g.FillPolygon(b, points);

            // Draw the triangle's outline
            g.DrawPolygon(p, points);
        }

        // Calculate area of the triangle (0.5 * base * height)
        public override double calcArea()
        {
            return 0.5 * baseLength * height;
        }

        // Calculate perimeter of the triangle (approximated as the sum of all sides)
        public override double calcPerimeter()
        {
            // Approximate the two side lengths using Pythagorean theorem
            double side = Math.Sqrt(Math.Pow(baseLength / 2, 2) + Math.Pow(height, 2));
            return baseLength + 2 * side;  // Perimeter of the triangle
        }
    }
}
