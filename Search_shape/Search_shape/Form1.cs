using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Search_shape
{

    // Main form class 
    public partial class Form1 : Form
    {
        private ShapeBase shape; // Current shape object displayed on the label

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Event handler for the "Draw Shape" button
        private void button1_Click(object sender, EventArgs e)
        {
            // Get user input and trim whitespace
            string input = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a shape and color."); // Prompt if input is empty
                return;
            }

            // Split input by comma
            string[] parts = input.Split(',');


            // Input must be in 2 or 3 parts ([shape],[color1],[color2])
            if (parts.Length < 2 || parts.Length > 3)
            {
                MessageBox.Show("Input must be in the format: shape,color1[,color2]");
                return;
            }

            // Extract shape type and color names
            string shapeType = parts[0].Trim().ToLower();
            string color1Name = parts[1].Trim().ToLower();
            string color2Name = parts.Length == 3 ? parts[2].Trim().ToLower() : null;

            Color color1, color2 = Color.Empty;

            try
            {
                // Convert color names to Color objects
                color1 = Color.FromName(color1Name);
                if (color1 == Color.Empty)
                {
                    MessageBox.Show("Invalid first color name.");
                    return;
                }

                if (!string.IsNullOrEmpty(color2Name))
                {
                    color2 = Color.FromName(color2Name);
                    if (color2 == Color.Empty)
                    {
                        MessageBox.Show("Invalid second color name.");
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error parsing colors.");
                return;
            }

            // Create the appropriate shape object based on the shape type
            switch (shapeType)
            {
                case "circle":
                    shape = new CircleShape("circle", color1, color2);
                    break;
                case "square":
                    shape = new SquareShape("square", color1, color2);
                    break;
                case "rectangle":
                    shape = new RectangleShape("rectangle", color1, color2);
                    break;
                case "triangle":
                    shape = new TriangleShape("triangle", color1, color2);
                    break;
                case "ellipse":
                    shape = new EllipseShape("ellipse", color1, color2);
                    break;
                default:
                    MessageBox.Show("Shape not recognized. Enter 'circle', 'square', 'rectangle', or 'triangle'.");
                    return;
            }

            // Redraw the label with the new shape
            label1.Invalidate();    // Force the label to repaint
            label1.Paint += Label1_Paint;   // Attach paint event to draw the shape
        }

        // Paint event handler for the label
        private void Label1_Paint(object sender, PaintEventArgs e)
        {
            if (shape != null)
            {
                // Call the shape's Draw method to render it on the label
                shape.Draw(e.Graphics);
            }
        }

        // Event handler for the "Clear" button
        private void button2_Click(object sender, EventArgs e)
        {
            shape = null; // Clear current shape
            label1.Invalidate(); // Redraw label empty
            textBox1.Clear(); // Clear text box
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
