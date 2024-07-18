using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Task4 : Form
    {
        private const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string DigitChars = "0123456789";
        private const string SpecialChars = "!@#$%^&*()-_=+[]{}\\|;:'\",<.>/?";

        public Task4()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int passwordLength = (int)numPasswordLength.Value;
            bool useLowercase = chkLowercase.Checked;
            bool useUppercase = chkUppercase.Checked;
            bool useDigits = chkDigits.Checked;
            bool useSpecialChars = chkSpecialChars.Checked;

            if (!useLowercase && !useUppercase && !useDigits && !useSpecialChars)
            {
                MessageBox.Show("Please select at least one character set.");
                return;
            }

            string charSet = "";
            if (useLowercase)
                charSet += LowercaseChars;
            if (useUppercase)
                charSet += UppercaseChars;
            if (useDigits)
                charSet += DigitChars;
            if (useSpecialChars)
                charSet += SpecialChars;

            Random random = new Random();
            string password = new string(Enumerable.Repeat(charSet, passwordLength)
                                          .Select(s => s[random.Next(s.Length)]).ToArray());

            txtGeneratedPassword.Text = password;
        }
    }
}
