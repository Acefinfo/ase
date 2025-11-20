using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_application
{
    interface Shapes
    {
        void SetPosition(int x, int y);
        void Draw(Graphics g, Pen myPen);
        string ToString();
    }


}
