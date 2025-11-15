using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_shape
{
    // EllipseShape class inherits from ShapeBase
    // Represents a drawable ellipse with optional gradient coloring
    public class EllipseShape : ShapeBase
    {
        // Default constructor
        public EllipseShape() { }

        // Constructor to initialize ellipse type and colors
        public EllipseShape(string shape, Color color1, Color color2)
            : base(shape, color1, color2) { }

        // Override the abstract Draw method from ShapeBase
        public override void Draw(Graphics g)
        {
            Brush brush;

            // If a secondary color is provided, use a gradient brush
            if (Color2 != Color.Empty)
            {
                brush = new LinearGradientBrush(
                    new Rectangle(50, 50, 200, 150),       // Rectangle bounds for the ellipse
                    Color1,                                // Starting color
                    Color2,                                // Ending color
                    LinearGradientMode.ForwardDiagonal     // Gradient direction
                );
            }
            else
            {
                // Otherwise, use a solid color brush
                brush = new SolidBrush(Color1);
            }

            // Draw the filled ellipse
            g.FillEllipse(brush, new Rectangle(50, 50, 200, 150));

            // Dispose the brush to free system resources
            brush.Dispose();
        }
    }
}
