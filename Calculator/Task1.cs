using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out double number1) && double.TryParse(txtNumber2.Text, out double number2))
            {
                double result = number1 + number2;
                txtResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both fields.");
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out double number1) && double.TryParse(txtNumber2.Text, out double number2))
            {
                double result = number1 - number2;
                txtResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both fields.");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out double number1) && double.TryParse(txtNumber2.Text, out double number2))
            {
                double result = number1 * number2;
                txtResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both fields.");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out double number1) && double.TryParse(txtNumber2.Text, out double number2))
            {
                if (number2 != 0)
                {
                    double result = number1 / number2;
                    txtResult.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Cannot divide by zero.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both fields.");
            }
        }
    }
}
