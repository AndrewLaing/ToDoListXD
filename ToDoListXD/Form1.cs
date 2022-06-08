using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ToDoListXD
{
    public enum CurrentView
    {
        AllUncompleted,
        AllCompleted,
        TodaysTasks,
        AllTasks
    }

    public partial class Form1 : Form
    {
        private Database dbObject;
        private AboutForm aboutForm = new AboutForm();
        private AddTaskForm addTaskForm = new AddTaskForm();
        private EditTaskForm editTaskForm = new EditTaskForm();
        private CurrentView currentView;
        private const string APP_NAME = "ToDoListXD";

        public Form1()
        {
            InitializeComponent();
            dbObject = new Database();
            ConfigureListView1();
            editTaskForm.btnSave.Click += new EventHandler(editFormSaveButtonClicked);
            addTaskForm.btnAddTask.Click += new EventHandler(addFormAddTaskButtonClicked);
        }

        private void ConfigureListView1()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Task", 240, HorizontalAlignment.Right);
            listView1.Columns.Add("Date", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Time", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("taskID", 0, HorizontalAlignment.Center);       // Hidden column
            listView1.Columns.Add("isCompleted", 0, HorizontalAlignment.Center);  // Hidden column

            var lvcs = new ListViewColumnSorter();
            listView1.ListViewItemSorter = lvcs;
            lvcs.OrderOfSort = SortOrder.Ascending;
            lvcs.ColumnToSort = 1;
        }

        private void UpdateReadyStatusLabel(bool isReady)
        {
            if(isReady)
            {
                readyStatusLabel.Text = "Ready";
            }
            else
            {
                readyStatusLabel.Text = "Processing...";
            }
        }

        #region "ListView update functions"

        private void PopulateListView(string query)
        {
            dbObject.OpenConnection();
            System.Drawing.Font completedTask = new System.Drawing.Font(
                                                        listView1.Font.FontFamily, 
                                                        listView1.Font.Size, 
                                                        System.Drawing.FontStyle.Strikeout);

            using (SQLiteConnection conn = new SQLiteConnection(dbObject.myConnection))
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(query, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                listView1.Items.Clear();
                listView1.BeginUpdate();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem lvi = new ListViewItem();
                    if(row["isCompleted"].ToString() == "1")
                    {
                        lvi.Font = completedTask;
                    }
                    lvi.Text = row["taskText"].ToString();
                    lvi.SubItems.Add(row["dateOfTask"].ToString());
                    lvi.SubItems.Add(row["timeOfTask"].ToString());
                    lvi.SubItems.Add(row["taskID"].ToString());      // hidden row
                    lvi.SubItems.Add(row["isCompleted"].ToString()); // hidden row
                    listView1.Items.Add(lvi);
                }
                listView1.EndUpdate();
            }
            dbObject.CloseConnection();
        }

        private void PopulateEditTaskForm()
        {
            int checkedItems = listView1.CheckedItems.Count;

            if (checkedItems == 1)
            {
                ListViewItem item = listView1.CheckedItems[0];
                editTaskForm.SetText(item.Text);
                editTaskForm.SetDate(item.SubItems[1].Text.ToString());
                editTaskForm.SetTime(item.SubItems[2].Text.ToString());
                editTaskForm.SetTaskID(item.SubItems[3].Text.ToString());
                editTaskForm.SetIsCompleted(item.SubItems[4].Text.ToString());
                editTaskForm.Show();
            }
            else if (checkedItems == 0)
            {
                MessageBox.Show("No items selected!", "ToDoListXD",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Items can only be edited one at a time!", "ToDoListXD",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefreshListView()
        {
            if (currentView == CurrentView.AllCompleted)
            {
                LoadAllCompletedTasks();
            }
            else if (currentView == CurrentView.AllUncompleted)
            {
                LoadAllUncompletedTasks();
            }
            else if (currentView == CurrentView.TodaysTasks)
            {
                LoadAllUncompletedTasksForToday();
            }
            else if (currentView == CurrentView.AllTasks)
            {
                LoadAllTasks();
            }
        }

        #endregion

        #region "SQLite query/command functions"

        private void DeleteSelectedTasks()
        {
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                string deleteTask = "DELETE FROM tasks WHERE taskID=@taskID";
                SQLiteCommand command = new SQLiteCommand(deleteTask, dbObject.myConnection);

                dbObject.OpenConnection();
                command.Parameters.AddWithValue("@taskID", item.SubItems[3].Text.ToString());

                var result = command.ExecuteNonQuery();
                dbObject.CloseConnection();
            }
        }

        private void InsertNewTaskUsingAddFormData()
        {
            string insertTask = "INSERT INTO tasks (taskText, isCompleted, dateOfTask, timeOfTask) VALUES (@taskText, @isCompleted, @dateOfTask, @timeOfTask)";
            SQLiteCommand command = new SQLiteCommand(insertTask, dbObject.myConnection);

            string date = addTaskForm.GetDate();
            string time = addTaskForm.GetTime();

            command.Parameters.AddWithValue("@taskText", addTaskForm.GetText());
            command.Parameters.AddWithValue("@isCompleted", 0);

            if (date.Length > 0)
            {
                command.Parameters.AddWithValue("@dateOfTask", date);
            }
            else
            {
                command.Parameters.AddWithValue("@dateOfTask", DBNull.Value);
            }

            if (time.Length > 0)
            {
                command.Parameters.AddWithValue("@timeOfTask", time);
            }
            else
            {
                command.Parameters.AddWithValue("@timeOfTask", DBNull.Value);
            }

            dbObject.OpenConnection();
            var result = command.ExecuteNonQuery();
            dbObject.CloseConnection();

            if (result != -1)
            {
                MessageBox.Show("Task added", "ToDoListXD");
            }
            else
            {
                MessageBox.Show("Error: Unable to add task", "ToDoListXD");
            }
        }

        private void LoadAllTasks()
        {
            string query = "Select * From tasks ORDER BY dateOfTask DESC, timeOfTask";
            PopulateListView(query);
            listView1.Sort();
            this.Text = APP_NAME + " - All Tasks";
        }

        private void LoadAllUncompletedTasks()
        {
            string query = "Select * From tasks WHERE isCompleted=0 ORDER BY dateOfTask DESC, timeOfTask";

            PopulateListView(query);
            listView1.Sort();
            this.Text = APP_NAME + " - All Uncompleted Tasks";
        }

        private void LoadAllCompletedTasks()
        {
            string query = "Select * From tasks WHERE isCompleted=1 ORDER BY dateOfTask DESC, timeOfTask";

            PopulateListView(query);
            listView1.Sort();
            this.Text = APP_NAME + " - All Completed Tasks";
        }

        private void LoadAllUncompletedTasksForToday()
        {
            DateTime thisDay = DateTime.Today;
            string today = thisDay.ToString("d");
            string query = "Select * From tasks WHERE isCompleted=0 "
                + "AND (dateOfTask LIKE '" + today
                + "' OR dateOfTask IS NULL) ORDER BY timeOfTask";

            PopulateListView(query);
            listView1.Sort();
            this.Text = APP_NAME + " - Today's Tasks";
        }

        private void MarkSelectedAsComplete()
        {
            bool db_changed = false;
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                UpdateReadyStatusLabel(false);
                string updateTask = "UPDATE tasks SET isCompleted=1 WHERE taskID=@taskID";
                SQLiteCommand command = new SQLiteCommand(updateTask, dbObject.myConnection);

                dbObject.OpenConnection();
                command.Parameters.AddWithValue("@taskID", item.SubItems[3].Text.ToString());

                var result = command.ExecuteNonQuery();
                dbObject.CloseConnection();

                db_changed = true;
                UpdateReadyStatusLabel(true);
            }

            if (db_changed)
            {
                RefreshListView();
            }
            else
            {
                MessageBox.Show("No items selected!", "ToDoListXD",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool UpdateTaskWithDataFromEditForm()
        {
            if (editTaskForm.GetIsCompleted() == "1")
            {
                var confirmResult = MessageBox.Show("This task will be changed to uncompleted,\nDo you wish to continue?",
                            "ToDoListXD", MessageBoxButtons.YesNo);
                if (confirmResult != DialogResult.Yes)
                {
                    editTaskForm.Hide();
                    return false;
                }
            }

            string updateTask = "UPDATE tasks SET taskText=@taskText, dateOfTask=@dateOfTask, timeOfTask=@timeOfTask, isCompleted=@isCompleted WHERE taskID=@taskID";
            SQLiteCommand command = new SQLiteCommand(updateTask, dbObject.myConnection);

            string date = editTaskForm.GetDate();
            string time = editTaskForm.GetTime();

            command.Parameters.AddWithValue("@taskText", editTaskForm.GetText());
            command.Parameters.AddWithValue("@taskID", editTaskForm.GetTaskID());
            command.Parameters.AddWithValue("@isCompleted", 0);

            if (date.Length > 0)
            {
                command.Parameters.AddWithValue("@dateOfTask", date);
            }
            else
            {
                command.Parameters.AddWithValue("@dateOfTask", DBNull.Value);
            }

            if (time.Length > 0)
            {
                command.Parameters.AddWithValue("@timeOfTask", time);
            }
            else
            {
                command.Parameters.AddWithValue("@timeOfTask", DBNull.Value);
            }

            dbObject.OpenConnection();
            var result = command.ExecuteNonQuery();
            dbObject.CloseConnection();

            if (result != -1)
            {
                MessageBox.Show("Task updated", "ToDoListXD");
                return true;
            }
            else
            {
                MessageBox.Show("Error: Unable to update task", "ToDoListXD");
                return false;
            }
        }

        #endregion

        #region "Event Handlers"

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = true;
            }
        }

        private void selectNoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = false;
            }
        }

        private void addNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTaskForm.Show();
        }

        private void editSelectedTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateEditTaskForm();
        }

        private void markSelectedAsCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkSelectedAsComplete();
        }

        private void deleteSelectedTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you want to delete the selected items?",
                                        "ToDoListXD", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            if (listView1.CheckedItems.Count > 0)
            {
                UpdateReadyStatusLabel(false);
                DeleteSelectedTasks();
                UpdateReadyStatusLabel(true);
                MessageBox.Show("The selected items have been deleted.", "ToDoListXD",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshListView();
            }
            else {
                MessageBox.Show("No items selected!", "ToDoListXD",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showTodaysTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReadyStatusLabel(false);
            LoadAllUncompletedTasksForToday();
            currentView = CurrentView.TodaysTasks;
            UpdateReadyStatusLabel(true);
        }

        private void showAllTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReadyStatusLabel(false);
            LoadAllTasks();
            UpdateReadyStatusLabel(true);
            currentView = CurrentView.AllTasks;
        }

        private void showAllUncompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReadyStatusLabel(false);
            LoadAllUncompletedTasks();
            currentView = CurrentView.AllUncompleted;
            UpdateReadyStatusLabel(true);
        }

        private void showAllCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReadyStatusLabel(false);
            LoadAllCompletedTasks();
            currentView = CurrentView.AllCompleted;
            UpdateReadyStatusLabel(true);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllUncompletedTasks();
            currentView = CurrentView.AllUncompleted;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // Ensure data entry forms retain focus when opened
            if (editTaskForm.Visible)
            {
                editTaskForm.Activate();
            }
            else if(addTaskForm.Visible)
            {
                addTaskForm.Activate();
            }
        }

        private void addFormAddTaskButtonClicked(object sender, EventArgs e)
        {
            UpdateReadyStatusLabel(false);
            InsertNewTaskUsingAddFormData();
            RefreshListView();
            UpdateReadyStatusLabel(true);
            addTaskForm.Hide();
        }

        private void editFormSaveButtonClicked(object sender, EventArgs e)
        {
            UpdateReadyStatusLabel(false);

            if (UpdateTaskWithDataFromEditForm())
            {
                RefreshListView();
                editTaskForm.Hide();
            }

            UpdateReadyStatusLabel(true);
        }

        #endregion
    }
}
