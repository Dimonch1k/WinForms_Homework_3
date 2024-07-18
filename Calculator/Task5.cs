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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string newTask = txtTask.Text.Trim();
            if (!string.IsNullOrEmpty(newTask))
            {
                listBoxTasks.Items.Add(newTask);
                txtTask.Clear();
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex);
            }
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex);
            }
        }
    }
}
