using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface_application
{
    /// <summary>
    /// Main application form responsible for displaying and drawing graphical shapes.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Circle instance used for drawing on the form.
        /// </summary>
        private Circle c;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class
        /// and sets up the circle object.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            c = new Circle();  // Initialize the Circle object here
        }

        /// <summary>
        /// Handles all custom drawing operations for the form.
        /// This method is triggered automatically whenever the form needs repainting.
        /// </summary>
        /// <param name="e">
        /// Contains the graphics context used for drawing.
        /// </param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);

            // Set the circle's position and draw it
            c.SetPosition(100, 300);
            c.Draw(g, myPen);

            // Optionally, show information about the circle
            MessageBox.Show(c.ToString());
        }
    }
}
