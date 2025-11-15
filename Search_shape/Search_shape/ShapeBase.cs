using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_shape
{

    // Abstract class representing the base class for shapes
    public abstract class ShapeBase
    {

        // Private fields to store the type and colors of the shape
        private string type;
        private Color color1;
        private Color color2;

        // Default constructor
        public ShapeBase() { }

        // Parameterized constructor to initialize the shape with type and colors
        public ShapeBase(string type, Color color1, Color color2)
        {
            this.type = type;
            this.color1 = color1;
            this.color2 = color2;
        }

        // Public property to get or set the type of the shape
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        // Public property to set or get the first color of the shape
        public Color Color1
        {
            get { return color1; }
            set { color1 = value; }
        }

        // Public property to set or get the second color of the shape

        public Color Color2
        {
            get { return color2; }
            set { Color2 = value; }
        }

        // Abstract method to draw the shape, to be implemented by derived classes
        public abstract void Draw(Graphics g);
    }
}
