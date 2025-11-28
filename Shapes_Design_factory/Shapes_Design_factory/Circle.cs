using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_design_factory
{
    public class Circle : Shape
    {
        int radious;

        // Parameterless constructor
        public Circle() : base()
        {
            radious = 50; // Default radious
        }

        // Parameterized constructor to initialize a Circle with color, position, and radious   
        public Circle(Color color, int x, int y, int radious) : base(color, x, y)
        {
            this.radious = radious;
        }

        public override void set(Color color, params int[] list)
        {
            base.set(color, list[0], list[1]);
            this.radious = list[2];
        }

        //Draw method to render the circle on a graphics object
        public override void draw(Graphics g)
        {
            Pen p = new Pen(this.color, 2); // Outline color with width 2
            SolidBrush b = new SolidBrush(this.color); // Fill color
            g.FillEllipse(b, x, y, radious, radious); // Draw filled circle
            g.DrawEllipse(p, x, y, radious, radious); // Draw circle outline
        }

        // Calculate area of the circle (π * r^2)
        public override double calcArea()
        {
            return Math.PI * radious * radious;
        }

        // Calculate perimeter of the circle (2 * π * r)    
        public override double calcPerimeter()
        {
            return 2 * Math.PI * radious; // Perimeter of circle
        }
    }


}
