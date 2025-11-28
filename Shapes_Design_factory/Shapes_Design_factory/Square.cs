using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_design_factory
{
    public class Square : Shape
    {
        private  int sideLength;
        public Square() : base()
        { 
            this.sideLength = 100; // Default side length
        }

        public Square(Color color, int x , int y , int sideLength) :base(color, x, y)
        {
            this.sideLength = sideLength;
        }


        public override void set(Color color, params int[] list)
        {
            // list[0] is x, list[1] is y, list[2] is sideLength
            base.set(color, list[0], list[1]);  // Set color and position using the base method
            this.sideLength = list[2];  // Set side length
        }

        // Draw method to render the square on a graphics object
        public override void draw(Graphics g)
        {
            Pen p = new Pen(this.color, 2);  // Outline color with width 2
            SolidBrush b = new SolidBrush(this.color);  // Fill color
            g.FillRectangle(b, x, y, sideLength, sideLength);  // Draw filled square
            g.DrawRectangle(p, x, y, sideLength, sideLength);  // Draw square outline
        }

        public override double calcArea()
        {
            return sideLength * sideLength; // Area of square
        }

        public override double calcPerimeter()
        {
            return 4 * sideLength; // Perimeter of square
        }







    }
}
