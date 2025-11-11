using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Search_shape
{
    public partial class Form1 : Form
    {
        // Declare global variables to store the shape and color
        private string shapeType = "";
        private Color shapeColor1 = Color.Empty;  // First color
        private Color shapeColor2 = Color.Empty;  // Second color (for gradient)

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a shape and color.");
                return;
            }

            string[] parts = input.Split(',');

            if (parts.Length < 2 || parts.Length > 3)
            {
                MessageBox.Show("Input must be in the format: shape,color1[,color2]");
                return;
            }

            shapeType = parts[0].Trim().ToLower(); // Store shape type
            string color1 = parts[1].Trim().ToLower(); // Store first color
            string color2 = parts.Length == 3 ? parts[2].Trim().ToLower() : null; // Store second color (if present)

            try
            {
                // Try to convert color1 and color2 to Color objects
                shapeColor1 = Color.FromName(color1);
                if (shapeColor1 == Color.Empty)
                {
                    MessageBox.Show("Invalid color name. Please insert a valid color name for the first color.");
                    return;
                }

                if (color2 != null)
                {
                    shapeColor2 = Color.FromName(color2);
                    if (shapeColor2 == Color.Empty)
                    {
                        MessageBox.Show("Invalid color name. Please insert a valid color name for the second color.");
                        return;
                    }
                }
                else
                {
                    shapeColor2 = Color.Empty;  // No second color, so reset the second color
                }
            }
            catch
            {
                MessageBox.Show("Invalid color name. Please insert valid color names.");
                return; // Exit the method if color is invalid
            }

            label1.Invalidate(); // Invalidate to trigger a redraw of the label
            label1.Paint += (paintSender, paintE) => DrawShape(paintE.Graphics); // Renamed parameters
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Reset the shape and color variables
            shapeType = "";
            shapeColor1 = Color.Empty;
            shapeColor2 = Color.Empty;

            // Clear the label by forcing a redraw with no shape
            label1.Invalidate();

            // Clear the text box
            textBox1.Clear();
        }

        // Method to draw the shape on the label
        private void DrawShape(Graphics g)
        {
            g.Clear(label1.BackColor); // Clear previous drawings

            if (string.IsNullOrEmpty(shapeType) || shapeColor1 == Color.Empty)
            {
                return; // Do nothing if no shape or color is defined
            }

            Brush brush = null;

            // If there are two colors (for gradient)
            if (shapeColor2 != Color.Empty)
            {
                // Use a LinearGradientBrush if two colors are specified
                brush = new LinearGradientBrush(
                    new Rectangle(50, 50, 150, 150), shapeColor1, shapeColor2, LinearGradientMode.ForwardDiagonal);
            }
            else
            {
                // Use a SolidBrush if only one color is specified
                brush = new SolidBrush(shapeColor1);
            }

            // Draw the shape based on the shapeType
            switch (shapeType)
            {
                case "circle":
                    g.FillEllipse(brush, new Rectangle(50, 50, 150, 150));
                    break;
                case "square":
                    g.FillRectangle(brush, new Rectangle(50, 50, 150, 150));
                    break;
                case "triangle":
                    Point[] points = {
                        new Point(125, 50),
                        new Point(50, 200),
                        new Point(200, 200)
                    };
                    g.FillPolygon(brush, points);
                    break;
                case "rectangle":
                    g.FillRectangle(brush, new Rectangle(50, 50, 200, 100));
                    break;
                default:
                    MessageBox.Show("Shape not recognized. Please enter 'rectangle', 'circle', 'square', or 'triangle'.");
                    break;
            }
        }
    }
}
