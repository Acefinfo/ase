using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Search_shape
{
    public partial class Form1 : Form
    {
        private ShapeBase shape; // Current shape object

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Not needed for now
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

            string shapeType = parts[0].Trim().ToLower();
            string color1Name = parts[1].Trim().ToLower();
            string color2Name = parts.Length == 3 ? parts[2].Trim().ToLower() : null;

            Color color1, color2 = Color.Empty;

            try
            {
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

            // Create the shape object based on type
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
                default:
                    MessageBox.Show("Shape not recognized. Enter 'circle', 'square', 'rectangle', or 'triangle'.");
                    return;
            }

            // Redraw label with the new shape
            label1.Invalidate();
            label1.Paint += Label1_Paint;
        }

        private void Label1_Paint(object sender, PaintEventArgs e)
        {
            if (shape != null)
            {
                shape.Draw(e.Graphics);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shape = null; // Clear current shape
            label1.Invalidate(); // Redraw label empty
            textBox1.Clear(); // Clear text box
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional initialization
        }
    }
}
