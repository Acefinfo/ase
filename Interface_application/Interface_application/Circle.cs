using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_application
{
    public class Circle : Shapes
    {
        private int x, y;
        private const int size = 20;
        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Draw(Graphics g, Pen myPen)
        {
            g.DrawEllipse(myPen, x - size, y - size, size * 2, size * 2);
        }
        public override string ToString()
        {
            return "Circle class, x, y, size =  " + x + " " + y;
        }
    }

}
