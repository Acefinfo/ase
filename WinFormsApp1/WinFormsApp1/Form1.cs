namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        double value = 0;   // Stre the current value 
        string operation = "";  // Store the current operation
        bool operationPressed = false;  // flag to check if an operation button was pressed

        // Constructor to initialize the form and wire up button click events
        public Form1()
        {
            InitializeComponent();
       

            // Hook up number and operator buttons (like before)
            button1.Click += Button_Click;  // 7
            button2.Click += Button_Click;  // 8
            button3.Click += Button_Click;  // 9
            button4.Click += Button_Click;  // 4
            button5.Click += Button_Click;  // 5
            button6.Click += Button_Click;  // 6
            button7.Click += Button_Click;  // 1
            button8.Click += Button_Click;  // 2
            button9.Click += Button_Click;  // 3
            button10.Click += Button_Click; // 0

            // Hook up operator buttons to their event handler
            button11.Click += Operator_Click; // -
            button12.Click += Operator_Click; // +
            button13.Click += Operator_Click; // *
            button14.Click += Operator_Click; // /

            // Hook up Clear and Equals buttons to their event handlers
            button15.Click += Clear_Click;   // CE
            button16.Click += Equal_Click;   // =
        }

        // Handles clicks on number buttons (0-9, .)
        private void Button_Click(object sender, EventArgs e)
        {
            // If the display is "0" or an operator was pressed, clear the textbox
            if (textBox1.Text == "0" || operationPressed)
                textBox1.Clear();

            operationPressed = false;   // Reset the flag after the user has entered a number
            Button b = (Button)sender;  // Get the button that was clicked

            // Prevent adding multiple decimal points
            if (b.Text == "." && textBox1.Text.Contains("."))
                return;

            textBox1.Text += b.Text;    // Append the clicked number or decimal to the textbox display
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;

            try
            {
                value = double.Parse(textBox1.Text);
            }
            catch
            {
                textBox1.Text = "0";
                value = 0;
            }

            operationPressed = true;


            label1.Text = $"{value} {operation}";
        }

        // Handles clicks on operator buttons
        private void Equal_Click(object sender, EventArgs e)
        {
            double secondValue;
            if (!double.TryParse(textBox1.Text, out secondValue))
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            double result = 0;
            switch (operation)
            {
                case "+": result = value + secondValue; break;
                case "-": result = value - secondValue; break;
                case "*": result = value * secondValue; break;
                case "/":
                    if (secondValue == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!");
                        return;
                    }
                    result = value / secondValue;
                    break;
                default:
                    result = secondValue;
                    break;
            }


            label1.Text = $"{value} {operation} {secondValue} =";

            textBox1.Text = result.ToString();
            value = result;
            operation = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            value = 0;
            operation = "";
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}