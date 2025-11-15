using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_shape
{

    // SquareShape class inherits from ShapeBase
    // Represents a drawable square with optional gradient coloring
    internal class SquareShape : ShapeBase
    {
        // Default constructor
        public SquareShape() { }

        // Parameterized constructor to initialize the square with type and colors

        public SquareShape(string shape, Color color1, Color color2) : base(shape, color1, color2) { }


        // Override the abstract Draw method from ShapeBase
        public override void Draw(Graphics g)
        {
            Brush brush;
            // If a secondary color is provided, create a gradient brush
            if (Color2 != Color.Empty)
            {
                brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    new Rectangle(50, 50, 150, 150),        // Rectangle bounds for gradient
                    Color1,                                 // Starting color
                    Color2,                                 // Ending color
                    System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal // Gradient direction
                );
            }
            else
            {
                // Otherwise, use a solid color brush
                brush = new SolidBrush(Color1);
            }

            // Draw the filled square
            g.FillRectangle(brush, new Rectangle(50, 50, 150, 150));

            // Dispose the brush to free system resources
            brush.Dispose();
        }
    }
}
