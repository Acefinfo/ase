using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_shape
{
    public class CircleShape : ShapeBase
    {
        public CircleShape() { }

        public CircleShape(string shape, Color color1, Color color2) : base(shape, color1, color2) { }

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

            g.FillEllipse(brush, new Rectangle(50, 50, 150, 150));

        }
    }
}
