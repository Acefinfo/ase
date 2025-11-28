using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Shapes_design_factory
{
    public partial class Form1 : Form
    {
        // List to hold shapes
        private List<Shape> shapes;

        public Form1()
        {
            InitializeComponent();

            // Initialize the shapes list
            shapes = new List<Shape>();

            // Create a factory instance
            ShapeFactory factory = new ShapeFactory();

            // Try adding shapes to the list
            try
            {
                // Adding some shapes statically (you can remove or modify this)
                shapes.Add(factory.getShape("circle"));
                shapes.Add(factory.getShape("rectangle"));
                shapes.Add(factory.getShape("triangle")); 
                shapes.Add(factory.getShape("square")); 
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Invalid shape: " + e);
            }

            // Add random shapes
            Random rand = new Random(77887);
            for (int i = 0; i < 150; i++)
            {
                int x = rand.Next(ClientSize.Width);  // Use ClientSize to ensure the shape stays within the form
                int y = rand.Next(ClientSize.Height);
                int size = rand.Next(250);

                int red = rand.Next(255);
                int green = rand.Next();
                int blue = rand.Next(255);

                Color newColour = Color.FromArgb(128, red, green, blue); // Semi-transparent color

                int shape = rand.Next(3);  // Randomly choose between circle, rectangle, or triangle
                Shape s;
                switch (shape)
                {
                    case 0:
                        s = factory.getShape("circle");
                        s.set(newColour, x, y, size);  // Set circle properties
                        shapes.Add(s);
                        break;
                    case 1:
                        s = factory.getShape("rectangle");
                        s.set(newColour, x, y, size, size);  // Set rectangle properties
                        shapes.Add(s);
                        break;
                    case 2:
                        s = factory.getShape("triangle");
                        s.set(newColour, x, y, size, size);  // Set triangle base and height
                        shapes.Add(s);
                        break;
                    case 3:
                        s = factory.getShape("square");
                        s.set(newColour, x, y, size);  // Set square properties
                        shapes.Add(s);
                        break;
                }
            }
        }

        // This method is called when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Override OnPaint to draw all the shapes on the form
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Loop through each shape in the list and draw it
            foreach (var shape in shapes)
            {
                shape.draw(e.Graphics);  // Draw each shape using the draw method
            }
        }
    }
}
