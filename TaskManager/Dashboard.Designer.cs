namespace TaskManager
{
    partial class Dashboard
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
            AddNewTask = new Button();
            EditTask = new Button();
            TaskDetails = new Button();
            RemoveTask = new Button();
            FilterTask = new Button();
            lblwelcome = new Label();
            Welcome = new Label();
            NoChartAvailableLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NumCompleted = new TextBox();
            NumPending = new TextBox();
            NumCanceled = new TextBox();
            SuspendLayout();
            // 
            // AddNewTask
            // 
            AddNewTask.BackColor = Color.LightCoral;
            AddNewTask.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            AddNewTask.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            AddNewTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            AddNewTask.FlatStyle = FlatStyle.Flat;
            AddNewTask.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewTask.ForeColor = Color.White;
            AddNewTask.Location = new Point(32, 58);
            AddNewTask.Name = "AddNewTask";
            AddNewTask.Size = new Size(157, 37);
            AddNewTask.TabIndex = 0;
            AddNewTask.Text = "Add New Task";
            AddNewTask.UseVisualStyleBackColor = false;
            AddNewTask.Click += AddNewTask_Click;
            // 
            // EditTask
            // 
            EditTask.BackColor = Color.LightCoral;
            EditTask.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            EditTask.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            EditTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            EditTask.FlatStyle = FlatStyle.Flat;
            EditTask.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditTask.ForeColor = Color.White;
            EditTask.Location = new Point(32, 142);
            EditTask.Name = "EditTask";
            EditTask.Size = new Size(157, 36);
            EditTask.TabIndex = 1;
            EditTask.Text = "Edit Task";
            EditTask.UseVisualStyleBackColor = false;
            EditTask.Click += EditTask_Click;
            // 
            // TaskDetails
            // 
            TaskDetails.BackColor = Color.LightCoral;
            TaskDetails.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            TaskDetails.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            TaskDetails.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            TaskDetails.FlatStyle = FlatStyle.Flat;
            TaskDetails.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaskDetails.ForeColor = Color.White;
            TaskDetails.Location = new Point(32, 335);
            TaskDetails.Name = "TaskDetails";
            TaskDetails.Size = new Size(157, 33);
            TaskDetails.TabIndex = 2;
            TaskDetails.Text = "Task Details";
            TaskDetails.UseVisualStyleBackColor = false;
            TaskDetails.Click += TaskDetails_Click;
            // 
            // RemoveTask
            // 
            RemoveTask.BackColor = Color.LightCoral;
            RemoveTask.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            RemoveTask.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            RemoveTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            RemoveTask.FlatStyle = FlatStyle.Flat;
            RemoveTask.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveTask.ForeColor = Color.White;
            RemoveTask.Location = new Point(32, 237);
            RemoveTask.Name = "RemoveTask";
            RemoveTask.Size = new Size(157, 35);
            RemoveTask.TabIndex = 3;
            RemoveTask.Text = "Remove Task";
            RemoveTask.UseVisualStyleBackColor = false;
            RemoveTask.Click += RemoveTask_Click;
            // 
            // FilterTask
            // 
            FilterTask.BackColor = Color.LightCoral;
            FilterTask.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            FilterTask.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            FilterTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            FilterTask.FlatStyle = FlatStyle.Flat;
            FilterTask.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterTask.ForeColor = Color.White;
            FilterTask.Location = new Point(32, 426);
            FilterTask.Name = "FilterTask";
            FilterTask.Size = new Size(157, 34);
            FilterTask.TabIndex = 4;
            FilterTask.Text = "Filter Tasks";
            FilterTask.UseVisualStyleBackColor = false;
            FilterTask.Click += FilterTask_Click;
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Location = new Point(295, 9);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(0, 20);
            lblwelcome.TabIndex = 5;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Cambria", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Welcome.ForeColor = Color.LightCoral;
            Welcome.Location = new Point(363, 47);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(199, 33);
            Welcome.TabIndex = 6;
            Welcome.Text = "Welcome! User";
            Welcome.Click += Welcome_Click;
            // 
            // NoChartAvailableLabel
            // 
            NoChartAvailableLabel.AutoSize = true;
            NoChartAvailableLabel.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NoChartAvailableLabel.ForeColor = Color.DarkGray;
            NoChartAvailableLabel.Location = new Point(295, 245);
            NoChartAvailableLabel.Name = "NoChartAvailableLabel";
            NoChartAvailableLabel.Size = new Size(361, 27);
            NoChartAvailableLabel.TabIndex = 7;
            NoChartAvailableLabel.Text = "No Chart Available ! Add New Task";
            NoChartAvailableLabel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(739, 101);
            label1.Name = "label1";
            label1.Size = new Size(246, 23);
            label1.TabIndex = 8;
            label1.Text = "Number of Completed Task ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(739, 229);
            label2.Name = "label2";
            label2.Size = new Size(219, 23);
            label2.TabIndex = 9;
            label2.Text = "Number of Pending Task";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(739, 357);
            label3.Name = "label3";
            label3.Size = new Size(226, 23);
            label3.TabIndex = 10;
            label3.Text = "Number of Canceled Task";
            // 
            // NumCompleted
            // 
            NumCompleted.Location = new Point(828, 142);
            NumCompleted.Name = "NumCompleted";
            NumCompleted.Size = new Size(65, 27);
            NumCompleted.TabIndex = 11;
            // 
            // NumPending
            // 
            NumPending.Location = new Point(828, 267);
            NumPending.Name = "NumPending";
            NumPending.Size = new Size(65, 27);
            NumPending.TabIndex = 12;
            // 
            // NumCanceled
            // 
            NumCanceled.Location = new Point(828, 395);
            NumCanceled.Name = "NumCanceled";
            NumCanceled.Size = new Size(65, 27);
            NumCanceled.TabIndex = 13;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(997, 496);
            Controls.Add(NumCanceled);
            Controls.Add(NumPending);
            Controls.Add(NumCompleted);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NoChartAvailableLabel);
            Controls.Add(Welcome);
            Controls.Add(lblwelcome);
            Controls.Add(FilterTask);
            Controls.Add(RemoveTask);
            Controls.Add(TaskDetails);
            Controls.Add(EditTask);
            Controls.Add(AddNewTask);
            Name = "Dashboard";
            Text = "Dashboard";
            FormClosing += Dashboard_FormClosing;
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddNewTask;
        private Button EditTask;
        private Button TaskDetails;
        private Button RemoveTask;
        private Button FilterTask;
        private Label lblwelcome;
        private Label Welcome;
        private Label NoChartAvailableLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NumCompleted;
        private TextBox NumPending;
        private TextBox NumCanceled;
    }
}