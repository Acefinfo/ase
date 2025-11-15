using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_shape
{
    internal class SquareShape : ShapeBase
    {
        public SquareShape() { }

        public SquareShape(string shape, Color color1, Color color2) : base(shape, color1, color2) { }

        public override void Draw(Graphics g)
        {
            Brush brush;
            if (Color2 != Color.Empty)
            {
                brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    new Rectangle(50, 50, 150, 150),
                    Color1, Color2,
                    System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
            }
            else
            {
                brush = new SolidBrush(Color1);
            }
            g.FillRectangle(brush, new Rectangle(50, 50, 150, 150));
        }
    }
}
