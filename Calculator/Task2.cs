using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void btnCelsiusToFahrenheit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtTemperature.Text, out double celsius))
            {
                double fahrenheit = celsius * 9 / 5 + 32;
                txtResult.Text = $"{celsius}°C = {fahrenheit}°F";
            }
            else
            {
                MessageBox.Show("Please enter a valid temperature in Celsius.");
            }
        }

        private void btnFahrenheitToCelsius_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtTemperature.Text, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                txtResult.Text = $"{fahrenheit}°F = {celsius}°C";
            }
            else
            {
                MessageBox.Show("Please enter a valid temperature in Fahrenheit.");
            }
        }
    }
}
