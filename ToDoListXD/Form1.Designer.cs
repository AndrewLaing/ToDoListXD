namespace ToDoListXD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.readyStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markSelectedAsCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showTodaysTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllUncompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTaskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedTaskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.markSelectedAsCompleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedTaskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showTodaysTasksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllTasksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllUncompletedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllCompletedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.CheckBoxes = true;
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(507, 520);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readyStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(520, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // readyStatusLabel
            // 
            this.readyStatusLabel.Name = "readyStatusLabel";
            this.readyStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.readyStatusLabel.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.selectNoneToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewTaskToolStripMenuItem,
            this.editSelectedTaskToolStripMenuItem,
            this.markSelectedAsCompleteToolStripMenuItem,
            this.deleteSelectedTaskToolStripMenuItem,
            this.toolStripSeparator2,
            this.showTodaysTasksToolStripMenuItem,
            this.showAllTasksToolStripMenuItem,
            this.showAllUncompletedToolStripMenuItem,
            this.showAllCompletedToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // selectNoneToolStripMenuItem
            // 
            this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
            this.selectNoneToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.selectNoneToolStripMenuItem.Text = "Select None";
            this.selectNoneToolStripMenuItem.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(315, 6);
            // 
            // addNewTaskToolStripMenuItem
            // 
            this.addNewTaskToolStripMenuItem.Name = "addNewTaskToolStripMenuItem";
            this.addNewTaskToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.addNewTaskToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.addNewTaskToolStripMenuItem.Text = "Add New Task                                ";
            this.addNewTaskToolStripMenuItem.Click += new System.EventHandler(this.addNewTaskToolStripMenuItem_Click);
            // 
            // editSelectedTaskToolStripMenuItem
            // 
            this.editSelectedTaskToolStripMenuItem.Name = "editSelectedTaskToolStripMenuItem";
            this.editSelectedTaskToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.editSelectedTaskToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.editSelectedTaskToolStripMenuItem.Text = "Edit Selected Task";
            this.editSelectedTaskToolStripMenuItem.Click += new System.EventHandler(this.editSelectedTaskToolStripMenuItem_Click);
            // 
            // markSelectedAsCompleteToolStripMenuItem
            // 
            this.markSelectedAsCompleteToolStripMenuItem.Name = "markSelectedAsCompleteToolStripMenuItem";
            this.markSelectedAsCompleteToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.markSelectedAsCompleteToolStripMenuItem.Text = "Mark Selected As Complete";
            this.markSelectedAsCompleteToolStripMenuItem.Click += new System.EventHandler(this.markSelectedAsCompleteToolStripMenuItem_Click);
            // 
            // deleteSelectedTaskToolStripMenuItem
            // 
            this.deleteSelectedTaskToolStripMenuItem.Name = "deleteSelectedTaskToolStripMenuItem";
            this.deleteSelectedTaskToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.deleteSelectedTaskToolStripMenuItem.Text = "Delete Selected Tasks";
            this.deleteSelectedTaskToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedTaskToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(315, 6);
            // 
            // showTodaysTasksToolStripMenuItem
            // 
            this.showTodaysTasksToolStripMenuItem.Name = "showTodaysTasksToolStripMenuItem";
            this.showTodaysTasksToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.showTodaysTasksToolStripMenuItem.Text = "Show Today\'s Tasks";
            this.showTodaysTasksToolStripMenuItem.Click += new System.EventHandler(this.showTodaysTasksToolStripMenuItem_Click);
            // 
            // showAllTasksToolStripMenuItem
            // 
            this.showAllTasksToolStripMenuItem.Name = "showAllTasksToolStripMenuItem";
            this.showAllTasksToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.showAllTasksToolStripMenuItem.Text = "Show All Tasks";
            this.showAllTasksToolStripMenuItem.Click += new System.EventHandler(this.showAllTasksToolStripMenuItem_Click);
            // 
            // showAllUncompletedToolStripMenuItem
            // 
            this.showAllUncompletedToolStripMenuItem.Name = "showAllUncompletedToolStripMenuItem";
            this.showAllUncompletedToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.showAllUncompletedToolStripMenuItem.Text = "Show All Uncompleted";
            this.showAllUncompletedToolStripMenuItem.Click += new System.EventHandler(this.showAllUncompletedToolStripMenuItem_Click);
            // 
            // showAllCompletedToolStripMenuItem
            // 
            this.showAllCompletedToolStripMenuItem.Name = "showAllCompletedToolStripMenuItem";
            this.showAllCompletedToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.showAllCompletedToolStripMenuItem.Text = "Show All Completed";
            this.showAllCompletedToolStripMenuItem.Click += new System.EventHandler(this.showAllCompletedToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem1,
            this.selectNoneToolStripMenuItem1,
            this.toolStripSeparator3,
            this.addNewTaskToolStripMenuItem1,
            this.editSelectedTaskToolStripMenuItem1,
            this.markSelectedAsCompleteToolStripMenuItem1,
            this.deleteSelectedTaskToolStripMenuItem1,
            this.toolStripSeparator4,
            this.showTodaysTasksToolStripMenuItem1,
            this.showAllTasksToolStripMenuItem1,
            this.showAllUncompletedToolStripMenuItem1,
            this.showAllCompletedToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(220, 236);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.selectAllToolStripMenuItem1.Text = "Select All";
            this.selectAllToolStripMenuItem1.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // selectNoneToolStripMenuItem1
            // 
            this.selectNoneToolStripMenuItem1.Name = "selectNoneToolStripMenuItem1";
            this.selectNoneToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.selectNoneToolStripMenuItem1.Text = "Select None";
            this.selectNoneToolStripMenuItem1.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
            // 
            // addNewTaskToolStripMenuItem1
            // 
            this.addNewTaskToolStripMenuItem1.Name = "addNewTaskToolStripMenuItem1";
            this.addNewTaskToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.addNewTaskToolStripMenuItem1.Text = "Add New Task";
            this.addNewTaskToolStripMenuItem1.Click += new System.EventHandler(this.addNewTaskToolStripMenuItem_Click);
            // 
            // editSelectedTaskToolStripMenuItem1
            // 
            this.editSelectedTaskToolStripMenuItem1.Name = "editSelectedTaskToolStripMenuItem1";
            this.editSelectedTaskToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.editSelectedTaskToolStripMenuItem1.Text = "Edit Selected Task";
            this.editSelectedTaskToolStripMenuItem1.Click += new System.EventHandler(this.editSelectedTaskToolStripMenuItem_Click);
            // 
            // markSelectedAsCompleteToolStripMenuItem1
            // 
            this.markSelectedAsCompleteToolStripMenuItem1.Name = "markSelectedAsCompleteToolStripMenuItem1";
            this.markSelectedAsCompleteToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.markSelectedAsCompleteToolStripMenuItem1.Text = "Mark Selected As Complete";
            this.markSelectedAsCompleteToolStripMenuItem1.Click += new System.EventHandler(this.markSelectedAsCompleteToolStripMenuItem_Click);
            // 
            // deleteSelectedTaskToolStripMenuItem1
            // 
            this.deleteSelectedTaskToolStripMenuItem1.Name = "deleteSelectedTaskToolStripMenuItem1";
            this.deleteSelectedTaskToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.deleteSelectedTaskToolStripMenuItem1.Text = "Delete Selected Tasks";
            this.deleteSelectedTaskToolStripMenuItem1.Click += new System.EventHandler(this.deleteSelectedTaskToolStripMenuItem_Click);
            // 
            // showTodaysTasksToolStripMenuItem1
            // 
            this.showTodaysTasksToolStripMenuItem1.Name = "showTodaysTasksToolStripMenuItem1";
            this.showTodaysTasksToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.showTodaysTasksToolStripMenuItem1.Text = "Show Today\'s Tasks";
            this.showTodaysTasksToolStripMenuItem1.Click += new System.EventHandler(this.showTodaysTasksToolStripMenuItem_Click);
            // 
            // showAllTasksToolStripMenuItem1
            // 
            this.showAllTasksToolStripMenuItem1.Name = "showAllTasksToolStripMenuItem1";
            this.showAllTasksToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.showAllTasksToolStripMenuItem1.Text = "Show All Tasks";
            this.showAllTasksToolStripMenuItem1.Click += new System.EventHandler(this.showAllTasksToolStripMenuItem_Click);
            // 
            // showAllUncompletedToolStripMenuItem1
            // 
            this.showAllUncompletedToolStripMenuItem1.Name = "showAllUncompletedToolStripMenuItem1";
            this.showAllUncompletedToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.showAllUncompletedToolStripMenuItem1.Text = "Show All Uncompleted";
            this.showAllUncompletedToolStripMenuItem1.Click += new System.EventHandler(this.showAllUncompletedToolStripMenuItem_Click);
            // 
            // showAllCompletedToolStripMenuItem1
            // 
            this.showAllCompletedToolStripMenuItem1.Name = "showAllCompletedToolStripMenuItem1";
            this.showAllCompletedToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.showAllCompletedToolStripMenuItem1.Text = "Show All Completed";
            this.showAllCompletedToolStripMenuItem1.Click += new System.EventHandler(this.showAllCompletedToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(216, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(216, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(520, 564);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ToDoListXD";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel readyStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectNoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markSelectedAsCompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTodaysTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllUncompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllCompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedTaskToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectNoneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewTaskToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editSelectedTaskToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem markSelectedAsCompleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedTaskToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showTodaysTasksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showAllTasksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showAllUncompletedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showAllCompletedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

