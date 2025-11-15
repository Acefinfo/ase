using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Search_shape
{
    // RectangleShape class inherits from ShapeBase
    // Represents a drawable rectangle with optional gradient coloring
    public class RectangleShape: ShapeBase
    {
        // Default Constructor
        public RectangleShape() { }

        // Parameterized constructor to initialize the rectangle with type and colors
        public RectangleShape(string shape, Color color1,Color color2) : base(shape, color1, color2) { }

        // Override the abstract Draw method from ShapeBase
        public override void Draw(Graphics g)
        {

            Brush brush;
            if (Color2 != Color.Empty)
            {
                brush = new LinearGradientBrush(
                    new Rectangle(50, 50, 150, 100),   // Rectangle bounds for gradient
                    Color1,                             // Starting color
                    Color2,                             // Ending color
                    LinearGradientMode.ForwardDiagonal  // Gradient direction
                );
            }
            else
            {
                // Otherwise, use a solid color brush
                brush = new SolidBrush(Color1);
            }

            // Draw the filled rectangle
            g.FillRectangle(brush, new Rectangle(50, 50, 150, 100));

            // Dispose the brush to free system resources
            brush.Dispose();
        }   
    }
}
