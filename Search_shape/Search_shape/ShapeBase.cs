using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_shape
{
    public abstract class ShapeBase
    {
        private string type;
        private Color color1;
        private Color color2;

        public ShapeBase() { }

        public ShapeBase(string type, Color color1, Color color2)
        {
            this.type = type;
            this.color1 = color1;
            this.color2 = color2;
        }


        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Color Color1
        {
            get { return color1; }
            set { color1 = value; }
        }

        public Color Color2
        {
            get { return color2; }
            set { Color2 = value; }
        }

        public abstract void Draw(Graphics g);
    }
}
