namespace Calculator
{
    partial class Task5
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
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(69, 42);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(314, 368);
            this.listBoxTasks.TabIndex = 0;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(400, 176);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(207, 23);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(400, 265);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(110, 23);
            this.btnDeleteTask.TabIndex = 2;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.Location = new System.Drawing.Point(400, 236);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(110, 23);
            this.btnMarkCompleted.TabIndex = 3;
            this.btnMarkCompleted.Text = "Mark Completed";
            this.btnMarkCompleted.UseVisualStyleBackColor = true;
            this.btnMarkCompleted.Click += new System.EventHandler(this.btnMarkCompleted_Click);
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(400, 138);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(207, 20);
            this.txtTask.TabIndex = 4;
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.btnMarkCompleted);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.listBoxTasks);
            this.Name = "Task5";
            this.Text = "Task5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnMarkCompleted;
        private System.Windows.Forms.TextBox txtTask;
    }
}