using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_application
{
    /// <summary>
    /// Defines the basic structure and behavior required for drawable shapes,
    /// including setting their position, drawing them, and returning a textual description.
    /// </summary>
    interface Shapes
    {
        /// <summary>
        /// Sets the position of the shape on the drawing surface.
        /// </summary>
        /// <param name="x">The X-coordinate of the shape.</param>
        /// <param name="y">The Y-coordinate of the shape.</param>
        void SetPosition(int x, int y);

        /// <summary>
        /// Draws the shape on the given graphics surface using the provided pen.
        /// </summary>
        /// <param name="g">The graphics object used to draw the shape.</param>
        /// <param name="myPen">The pen used to outline the shape.</param>
        void Draw(Graphics g, Pen myPen);

        /// <summary>
        /// Returns a textual description of the shape.
        /// </summary>
        /// <returns>A string describing the shape.</returns>
        string ToString();
    }
}
