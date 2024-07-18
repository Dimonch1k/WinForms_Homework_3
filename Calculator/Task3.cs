using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Task3 : Form
    {
        private Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>
        {
            { "apple", new List<string> { "яблуко", "фрукт, який росте на яблунях" } },
            { "banana", new List<string> { "банан", "тропічний фрукт зі смачним плодом" } },
            { "cat", new List<string> { "кіт", "маленький хижий ссавець" } },
            { "orange", new List<string> { "апельсин", "соковитий цитрусовий фрукт" } },
            { "strawberry", new List<string> { "полуниця", "солодкий плід з кисломалиновим смаком" } },
            { "watermelon", new List<string> { "кавун", "великий солодкий плід з багатьма насіннями" } }
        };

        public Task3()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string word = txtWord.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Please enter a word to search.");
                return;
            }

            if (dictionary.ContainsKey(word))
            {
                List<string> wordInfo = dictionary[word];
                string translation = wordInfo[0];
                string definition = wordInfo[1];

                txtTranslation.Text = $"{translation}";
                txtDefinition.Text = $"{definition}";
            }
            else
            {
                MessageBox.Show($"Word '{word}' not found in the dictionary.");
            }
        }
    }
}
