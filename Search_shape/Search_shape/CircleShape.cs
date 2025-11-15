using System;
using System.Collections.Generic;
using System.Drawing;          
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_shape
{
    // CircleShape class inherits from ShapeBase
    // Represents a drawable circle with optional gradient coloring
    public class CircleShape : ShapeBase
    {
        // Default constructor
        public CircleShape() { }

        // Constructor to initialize circle type and colors
        public CircleShape(string shape, Color color1, Color color2)
            : base(shape, color1, color2) { }

        // Override the abstract Draw method from ShapeBase
        public override void Draw(Graphics g)
        {
            Brush brush;

            // If a secondary color is provided, create a gradient brush
            if (Color2 != Color.Empty)
            {
                brush = new LinearGradientBrush(
                    new Rectangle(50, 50, 150, 150),       // Rectangle bounds for gradient
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

            // Draw the filled circle (ellipse with equal width and height)
            g.FillEllipse(brush, new Rectangle(50, 50, 150, 150));

            // Dispose the brush to free system resources
            brush.Dispose();
        }
    }
}
