namespace Calculator
{
    // Refactor code, untidy

    public partial class Form1 : Form
    {
        int currentIndex = 0;
        decimal currentValue = 0;
        decimal[] operands = { 0, 0 };
        List<decimal> memory = new List<decimal>();
        String operation = "";
        bool equalClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void clearEverything()
        {
            currentIndex = 0;
            currentValue = 0;
            operands[0] = 0;
            operands[1] = 0;
            memory.Clear();
            operation = "";
            inputScreen.Clear();
            outputScreen.Clear();
            equalClicked = false;
        }

        private void getFirstOperand()
        {
            operands[currentIndex] = (inputScreen.Text != "") ? Convert.ToDecimal(inputScreen.Text) : 0;
            outputScreen.Text = operands[currentIndex].ToString();
            inputScreen.Clear();
            currentIndex++;   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Maximum length of number 10
            // Add the setting of values here

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // No errors so far
            clearEverything();
        }

        private void btnParenthesis_Click(object sender, EventArgs e)
        {
            // Add code here to allow for parenthesis
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            // No errors so far
            if (inputScreen.Text != "")
            {
                if (inputScreen.Text.StartsWith("-"))
                {
                    inputScreen.Text = inputScreen.Text.Substring(1);
                }
                else
                {
                    inputScreen.Text = "-" + inputScreen.Text;
                }
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            // Add history functionality
            if (currentIndex == 1)
            {
                if (!equalClicked)
                {
                    operands[currentIndex] = (inputScreen.Text != "") ? Convert.ToDecimal(inputScreen.Text) : 0;
                }
                switch (operation)
                {
                    case "+":
                        currentValue = operands[0] + operands[1];
                        break;
                    case "-":
                        currentValue = operands[0] - operands[1];
                        break;
                    case "*":
                        currentValue = operands[0] * operands[1];
                        break;
                    case "/":
                        try
                        {
                            currentValue = operands[0] / operands[1];
                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("Cannot divide by Zero. All values reset.", "Arithmetic Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnZero.PerformClick();
                        }
                        break;
                }
            }
            else
            {
                currentValue = (inputScreen.Text != "") ? Convert.ToDecimal(inputScreen.Text) : 0;
            }
            inputScreen.Clear();
            outputScreen.Text = Convert.ToString(currentValue);
            memory.Add(currentValue);
            operands[0] = currentValue;
            equalClicked = true;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (equalClicked)
            {
                clearEverything();
            }
            if (inputScreen.Text.Length < 10 && !inputScreen.Text.StartsWith("0"))
            {
                inputScreen.Text += "0";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (equalClicked)
            {
                clearEverything();
            }
            if (inputScreen.Text.Length < 10)
            {
                inputScreen.Text += "1";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (equalClicked)
            {
                clearEverything();
            }
            if (inputScreen.Text.Length < 10)
            {
                inputScreen.Text += "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (equalClicked)
            {
                clearEverything();
            }
            if (inputScreen.Text.Length < 10)
            {
                inputScreen.Text += "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (equalClicked)
            {
                clearEverything();
            }
            if (inputScreen.Text.Length < 10)
            {
                inputScreen.Text += "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (equalClicked)
            {
                clearEverything();
            }
            if (inputScreen.Text.Length < 10)
            {
                inputScreen.Text += "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (equalClicked)
            {
                clearEverything();
            }
            if (inputScreen.Text.Length < 10)
            {
                inputScreen.Text += "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (equalClicked)
            {
                clearEverything();
            }
            if (inputScreen.Text.Length < 10)
            {
                inputScreen.Text += "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (equalClicked)
            {
                clearEverything();
            }
            if (inputScreen.Text.Length < 10)
            {
                inputScreen.Text += "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (equalClicked)
            {
                clearEverything();
            }
            if (inputScreen.Text.Length < 10)
            {
                inputScreen.Text += "9";
            }
        }

        private void outputScreen_TextChanged(object sender, EventArgs e)
        {
            if (currentValue != 0)
            {
                outputScreen.Text = Math.Round(currentValue, 3).ToString();
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            // No errors so far
            if (inputScreen.Text == "")
            {
                // Dummy to avoid error on Convert.ToDecimal in line 231
            }
            else if (inputScreen.Text != "" && inputScreen.Text.Length <= 8 && Convert.ToDecimal(inputScreen.Text) != 0)
            {
                inputScreen.Text = Convert.ToString((Convert.ToDecimal(inputScreen.Text)) / 100);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "+";
            if (currentIndex == 0)
            {
                getFirstOperand();
            }
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            operation += "-";
            if (currentIndex == 0)
            {
                getFirstOperand();
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = "*";
            if (currentIndex == 0)
            {
                getFirstOperand();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            if (currentIndex == 0)
            {
                getFirstOperand();
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // No errors so far
            if (!(inputScreen.Text.Contains(",")))
            {
                if (inputScreen.Text == "") {
                    inputScreen.Text += "0,";
                }
                else {
                    inputScreen.Text += ",";

                }
            }
        }
    }
}