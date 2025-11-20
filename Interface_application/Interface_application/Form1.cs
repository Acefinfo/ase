using System;
using System.Drawing;  // Make sure you have the right namespace for Graphics
using System.Windows.Forms;

namespace Interface_application
{
    public partial class Form1 : Form
    {
        // Declare the Circle object at the class level, so both methods can access it
        private Circle c;

        public Form1()
        {
            InitializeComponent();
            c = new Circle();  // Initialize the Circle object here
        }

        // Override OnPaint to handle custom drawing
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);

            // Set the circle's position and draw it
            c.SetPosition(100, 100);
            c.Draw(g, myPen);

            // Optionally, show information about the circle (e.g., in the MessageBox)
            MessageBox.Show(c.ToString());
        }

        
    }
}
