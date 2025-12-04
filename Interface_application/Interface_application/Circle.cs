using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_application
{
    /// <summary>
    /// Represents a drawable circle shape that inherits from the <see cref="Shapes"/> base class.
    /// Allows setting its position and drawing it on a graphics surface.
    /// </summary>
    public class Circle : Shapes
    {
        /// <summary>
        /// The X-coordinate of the center of the circle.
        /// </summary>
        private int x;

        /// <summary>
        /// The Y-coordinate of the center of the circle.
        /// </summary>
        private int y;

        /// <summary>
        /// The radius of the circle (constant size).
        /// </summary>
        private const int size = 20;

        /// <summary>
        /// Sets the position of the circle on the drawing surface.
        /// </summary>
        /// <param name="x">The X-coordinate of the circle's center.</param>
        /// <param name="y">The Y-coordinate of the circle's center.</param>
        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Draws the circle on the provided graphics surface using the specified pen.
        /// </summary>
        /// <param name="g">The graphics object used to draw the circle.</param>
        /// <param name="myPen">The pen used to outline the circle.</param>
        public void Draw(Graphics g, Pen myPen)
        {
            g.DrawEllipse(myPen, x - size, y - size, size * 2, size * 2);
        }

        /// <summary>
        /// Returns a string representation of the circle, including its position and size.
        /// </summary>
        /// <returns>A string describing the circle's properties.</returns>
        public override string ToString()
        {
            return "Circle class, x, y, size = " + x + " " + y;
        }
    }
}
