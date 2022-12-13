namespace Calculator
{
    public partial class Form1 : Form
    {

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            this.InputDisplay.Text = "";
            input += "1";
            this.InputDisplay.Text += input;
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            this.InputDisplay.Text = "";
            input += "2";
            this.InputDisplay.Text += input;
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            this.InputDisplay.Text = "";
            input += "3";
            this.InputDisplay.Text += input;
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            this.InputDisplay.Text = "";
            input += "4";
            this.InputDisplay.Text += input;
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            this.InputDisplay.Text = "";
            input += "5";
            this.InputDisplay.Text += input;
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            this.InputDisplay.Text = "";
            input += "6";
            this.InputDisplay.Text += input;
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            this.InputDisplay.Text = "";
            input += "7";
            this.InputDisplay.Text += input;
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            this.InputDisplay.Text = "";
            input += "8";
            this.InputDisplay.Text += input;
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            this.InputDisplay.Text = "";
            input += "9";
            this.InputDisplay.Text += input;
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            this.InputDisplay.Text = "";
            input += "0";
            this.InputDisplay.Text += input;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            if (result != 0)
            { num1 = result; }
            else
            { double.TryParse(operand1, out num1); }
            double.TryParse(operand2, out num2);

            this.InputDisplay.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                InputDisplay.Text = result.ToString();
            } 
            else if (operation == '-') 
            {
                result = num1 - num2;
                InputDisplay.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                InputDisplay.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    InputDisplay.Text = result.ToString();
                }
                else
                {
                    InputDisplay.Text = "DIV/Zero!";
                }
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.InputDisplay.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.result = 0;
        }

        private void buttonDecimalPoint_Click(object sender, EventArgs e)
        {
            this.InputDisplay.Text = "";
            input += ".";
            this.InputDisplay.Text += input;
        }
    }
}