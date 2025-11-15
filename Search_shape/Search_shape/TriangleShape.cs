using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Search_shape
{
    // TriangleShape class inherits from ShapeBase
    // Represents a drawable triangle with optional gradient coloring

    internal class TriangleShape : ShapeBase
    {
        // Default constructor
        public TriangleShape() { }

        // Parameterized constructor to initialize the triangle with type and colors
        public TriangleShape(string shape, Color color1, Color color2) : base(shape, color1, color2) { }


        // Mthord override to draw the triangle on the provided Graphics object
        public override void Draw(Graphics g)
        {
            Brush brush;
            if (Color2 != Color.Empty)
            {
                // If a secondary color is provided, create a gradient brush
                brush = new LinearGradientBrush(
                    new Rectangle(50, 50, 150, 150),    // Area for the gradient
                    Color1, // Starting color
                    Color2, // Ending color
                    LinearGradientMode.ForwardDiagonal);    // Gradient direction
            }
            else
            {
                // Otherwise, use a solid color brush
                brush = new SolidBrush(Color1);
            }

            // Define the three points of the triangle
            Point[] points = {
                new Point(125, 50),   // Top vertex
                new Point(50, 200),   // Bottom-left vertex
                new Point(200, 200)   // Bottom-right vertex
            };
            // Draw the filled triangle on the graphics object
            g.FillPolygon(brush, points);

            // Dispose the brush to free resources
            brush.Dispose();
        }
    }
}
