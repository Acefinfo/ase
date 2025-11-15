using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_shape
{
    public abstract class Shape
    {
        protected Color shapecolor1;
        protected Color shapecolor2;

        public Shape(Color color1, Color color2)
        {
            shapecolor1 = color1;
            shapecolor2 = color2;
        }

        public abstract void Draw(Graphics g);

        protected Brush CreateBrush()
        {
            if (shapecolor2 != Color.Empty)
            {
                
                Rectangle rect = new Rectangle(0, 0, 100, 100);
                return new LinearGradientBrush(new Rectangle(50,50,150,150), shapecolor1,shapecolor2, System.Drawing2D.LinearGradientMode.ForwardDiagonal);
            }
            else

            {
                return new SolidBrush(shapecolor1);
            }
        }
    }
}
