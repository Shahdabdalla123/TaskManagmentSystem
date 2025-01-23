namespace TaskManager
{
    partial class TaskDetails
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
            SearchtextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            NameTextBox = new TextBox();
            StatusTextBox = new TextBox();
            PrioriryTextBox = new TextBox();
            DealineTextBox = new TextBox();
            CategoryIDTextBox = new TextBox();
            CategoryNameTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // SearchtextBox
            // 
            SearchtextBox.Location = new Point(261, 144);
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.Size = new Size(440, 27);
            SearchtextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(377, 62);
            label1.Name = "label1";
            label1.Size = new Size(166, 33);
            label1.TabIndex = 1;
            label1.Text = "Task Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 148);
            label2.Name = "label2";
            label2.Size = new Size(187, 23);
            label2.TabIndex = 2;
            label2.Text = "Search by Task Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 255);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 3;
            label3.Text = "Name";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 334);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 4;
            label4.Text = "Status";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 423);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 5;
            label5.Text = "Priority";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(466, 255);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 6;
            label6.Text = "Deadline";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(466, 334);
            label7.Name = "label7";
            label7.Size = new Size(110, 23);
            label7.TabIndex = 7;
            label7.Text = "Category ID";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(466, 423);
            label8.Name = "label8";
            label8.Size = new Size(150, 23);
            label8.TabIndex = 8;
            label8.Text = "Catergory Name";
            label8.Visible = false;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(165, 252);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(213, 27);
            NameTextBox.TabIndex = 9;
            NameTextBox.Visible = false;
            NameTextBox.TextChanged += Name_TextChanged;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Location = new Point(165, 334);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(213, 27);
            StatusTextBox.TabIndex = 10;
            StatusTextBox.Visible = false;
            // 
            // PrioriryTextBox
            // 
            PrioriryTextBox.Location = new Point(165, 419);
            PrioriryTextBox.Name = "PrioriryTextBox";
            PrioriryTextBox.Size = new Size(213, 27);
            PrioriryTextBox.TabIndex = 11;
            PrioriryTextBox.Visible = false;
            // 
            // DealineTextBox
            // 
            DealineTextBox.Location = new Point(640, 251);
            DealineTextBox.Name = "DealineTextBox";
            DealineTextBox.Size = new Size(213, 27);
            DealineTextBox.TabIndex = 12;
            DealineTextBox.Visible = false;
            // 
            // CategoryIDTextBox
            // 
            CategoryIDTextBox.Location = new Point(640, 334);
            CategoryIDTextBox.Name = "CategoryIDTextBox";
            CategoryIDTextBox.Size = new Size(213, 27);
            CategoryIDTextBox.TabIndex = 13;
            CategoryIDTextBox.Visible = false;
            // 
            // CategoryNameTextBox
            // 
            CategoryNameTextBox.Location = new Point(640, 419);
            CategoryNameTextBox.Name = "CategoryNameTextBox";
            CategoryNameTextBox.Size = new Size(213, 27);
            CategoryNameTextBox.TabIndex = 14;
            CategoryNameTextBox.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(753, 136);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 15;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.FlatAppearance.BorderColor = Color.MistyRose;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.LightCoral;
            button2.Location = new Point(39, 62);
            button2.Name = "button2";
            button2.Size = new Size(94, 49);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // TaskDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(919, 496);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CategoryNameTextBox);
            Controls.Add(CategoryIDTextBox);
            Controls.Add(DealineTextBox);
            Controls.Add(PrioriryTextBox);
            Controls.Add(StatusTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchtextBox);
            Name = "TaskDetails";
            Text = "TaskDetails";
            FormClosing += TaskDetails_FormClosing;
            Load += TaskDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchtextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox NameTextBox;
        private TextBox StatusTextBox;
        private TextBox PrioriryTextBox;
        private TextBox DealineTextBox;
        private TextBox CategoryIDTextBox;
        private TextBox CategoryNameTextBox;
        private Button button1;
        private Button button2;
    }
}