using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Search_shape
{
    internal class TriangleShape : ShapeBase
    {

        public TriangleShape() { }
        public TriangleShape(string shape, Color color1, Color color2) : base(shape, color1, color2) { }

        public override void Draw(Graphics g)
        {
            Brush brush;
            if (Color2 != Color.Empty)
            {
                brush = new LinearGradientBrush(
                    new Rectangle(50, 50, 150, 150),
                    Color1, Color2,
                    LinearGradientMode.ForwardDiagonal);
            }
            else
            {
                brush = new SolidBrush(Color1);
            }
            Point[] points = {
                new Point(125, 50),
                new Point(50, 200),
                new Point(200, 200)
            };
            g.FillPolygon(brush, points);
        }
    }
}
