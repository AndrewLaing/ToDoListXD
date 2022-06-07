using System;
using System.Windows.Forms;

namespace ToDoListXD
{
    public partial class EditTaskForm : Form
    {
        private string taskID;
        private string isCompleted;

        public EditTaskForm()
        {
            InitializeComponent();
        }

        private void EditTaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        public string GetText()
        {
            return textBox1.Text;
        }

        public string GetDate()
        {
            if (checkBox1.Checked)
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
            if (checkBox2.Checked)
            {
                return "";
            }
            else
            {
                return dateTimePicker2.Value.ToString("HH:mm");
            }
        }

        public string GetTaskID()
        {
            return taskID;
        }

        public string GetIsCompleted()
        {
            return isCompleted;
        }

        public void SetDate(string date)
        {
            try
            {
                dateTimePicker1.Value = DateTime.Parse(date);
            }
            catch
            {
                checkBox1.Checked = true;
            }
        }

        public void SetTime(string time)
        {
            try
            {
                dateTimePicker2.Value = DateTime.Parse(time);
            }
            catch
            {
                checkBox2.Checked = true;
            }
        }

        public void SetTaskID(string id)
        {
            taskID = id;
        }

        public void SetIsCompleted(string isComp)
        {
            isCompleted = isComp;
        }

        public void SetText(string text)
        {
            textBox1.Text = text;
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
