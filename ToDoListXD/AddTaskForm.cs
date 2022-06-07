using System;
using System.Windows.Forms;

namespace ToDoListXD
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }

        public string GetText()
        {
            return textBox1.Text;
        }

        public string GetDate()
        {
            if(checkBox1.Checked)
            {
                return "";
            }
            else
            {
                return dateTimePicker1.Value.ToString("dd/MM/yyyy");
            }
        }

        public string GetTime()
        {
            if(checkBox2.Checked)
            {
                return "";
            }
            else
            {
                return dateTimePicker2.Value.ToString("HH:mm");
            }
        }

        private void AddTaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Enabled)
            {
                dateTimePicker1.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Enabled)
            {
                dateTimePicker2.Enabled = false;
            }
            else
            {
                dateTimePicker2.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
