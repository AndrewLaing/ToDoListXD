using System.Data.SQLite;
using System.IO;

namespace ToDoListXD
{
    class Database
    {
        public SQLiteConnection myConnection;
        private string DEFAULT_DBNAME = "tasksDB.sqlite3";

        public Database()
        {
            CreateNewConnection(DEFAULT_DBNAME);

            if (!File.Exists(DEFAULT_DBNAME))
            {
                System.Windows.Forms.MessageBox.Show("Database file " + DEFAULT_DBNAME +  "not found\nA new database file with this name\nwill be created!",
                                                      "ToDoListXD",
                                                      System.Windows.Forms.MessageBoxButtons.OK,
                                                      System.Windows.Forms.MessageBoxIcon.Warning);
                CreateNewDatabase(DEFAULT_DBNAME);
            }
        }

        public void CreateNewConnection(string db_name)
        {
            string connStr = "Data Source=" + db_name;
            myConnection = new SQLiteConnection(connStr);
        }

        public void CreateNewDatabase(string db_name)
        {
            SQLiteConnection.CreateFile(db_name);
            string createTasksDB = "CREATE TABLE \"tasks\"("
                                              + "\"taskID\" INTEGER, "
                                              + "\"taskText\" TEXT NOT NULL, "
                                              + "\"isCompleted\" INTEGER NOT NULL, "
                                              + "\"dateOfTask\" TEXT, "
                                              + "\"timeOfTask\" TEXT, "
                                              + " PRIMARY KEY(\"taskID\" AUTOINCREMENT)"
                                              + ");";
            OpenConnection();

            SQLiteCommand command = new SQLiteCommand(createTasksDB, myConnection);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}

