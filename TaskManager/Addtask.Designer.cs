namespace TaskManager
{
    partial class Addtask
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
            AddNewTasklabel = new Label();
            NameTextbox = new TextBox();
            dateTimePicker = new DateTimePicker();
            PrioritycomboBox = new ComboBox();
            StatuscomboBox = new ComboBox();
            AddButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CategorycomboBox = new ComboBox();
            label5 = new Label();
            otherTextbox = new TextBox();
            otherlabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // AddNewTasklabel
            // 
            AddNewTasklabel.AutoSize = true;
            AddNewTasklabel.Font = new Font("Cambria", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AddNewTasklabel.ForeColor = Color.LightCoral;
            AddNewTasklabel.Location = new Point(354, 38);
            AddNewTasklabel.Name = "AddNewTasklabel";
            AddNewTasklabel.Size = new Size(189, 33);
            AddNewTasklabel.TabIndex = 0;
            AddNewTasklabel.Text = "Add New Task";
            AddNewTasklabel.Click += label1_Click;
            // 
            // NameTextbox
            // 
            NameTextbox.BackColor = Color.Snow;
            NameTextbox.Location = new Point(148, 124);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(227, 27);
            NameTextbox.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarFont = new Font("Cambria", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker.CalendarMonthBackground = Color.Snow;
            dateTimePicker.Location = new Point(615, 124);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(227, 27);
            dateTimePicker.TabIndex = 2;
            dateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // PrioritycomboBox
            // 
            PrioritycomboBox.BackColor = Color.Snow;
            PrioritycomboBox.FormattingEnabled = true;
            PrioritycomboBox.Location = new Point(148, 235);
            PrioritycomboBox.Name = "PrioritycomboBox";
            PrioritycomboBox.Size = new Size(227, 28);
            PrioritycomboBox.TabIndex = 3;
            // 
            // StatuscomboBox
            // 
            StatuscomboBox.BackColor = Color.Snow;
            StatuscomboBox.FormattingEnabled = true;
            StatuscomboBox.Location = new Point(148, 350);
            StatuscomboBox.Name = "StatuscomboBox";
            StatuscomboBox.Size = new Size(227, 28);
            StatuscomboBox.TabIndex = 4;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.LightCoral;
            AddButton.FlatAppearance.BorderColor = Color.LightCoral;
            AddButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            AddButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(742, 428);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 42);
            AddButton.TabIndex = 5;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 128);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 240);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 7;
            label2.Text = "Priority";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 355);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 8;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(484, 128);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 9;
            label4.Text = "DeadLine";
            // 
            // CategorycomboBox
            // 
            CategorycomboBox.BackColor = Color.Snow;
            CategorycomboBox.FormattingEnabled = true;
            CategorycomboBox.Location = new Point(615, 230);
            CategorycomboBox.Name = "CategorycomboBox";
            CategorycomboBox.Size = new Size(227, 28);
            CategorycomboBox.TabIndex = 10;
            CategorycomboBox.SelectedIndexChanged += CategorycomboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(484, 240);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 11;
            label5.Text = "Category";
            // 
            // otherTextbox
            // 
            otherTextbox.BackColor = Color.Snow;
            otherTextbox.Location = new Point(615, 350);
            otherTextbox.Name = "otherTextbox";
            otherTextbox.Size = new Size(227, 27);
            otherTextbox.TabIndex = 12;
            otherTextbox.Visible = false;
            // 
            // otherlabel
            // 
            otherlabel.AutoSize = true;
            otherlabel.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otherlabel.Location = new Point(484, 355);
            otherlabel.Name = "otherlabel";
            otherlabel.Size = new Size(59, 23);
            otherlabel.TabIndex = 13;
            otherlabel.Text = "Other";
            otherlabel.Visible = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.MistyRose;
            button1.FlatAppearance.MouseDownBackColor = Color.MistyRose;
            button1.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LightCoral;
            button1.Location = new Point(14, 26);
            button1.Name = "button1";
            button1.Size = new Size(94, 49);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Addtask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(919, 496);
            Controls.Add(button1);
            Controls.Add(otherlabel);
            Controls.Add(otherTextbox);
            Controls.Add(label5);
            Controls.Add(CategorycomboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Controls.Add(StatuscomboBox);
            Controls.Add(PrioritycomboBox);
            Controls.Add(dateTimePicker);
            Controls.Add(NameTextbox);
            Controls.Add(AddNewTasklabel);
            Name = "Addtask";
            Text = "Addtask";
            FormClosing += Addtask_FormClosing;
            Load += Addtask_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddNewTasklabel;
        private TextBox NameTextbox;
        private DateTimePicker dateTimePicker;
        private ComboBox PrioritycomboBox;
        private ComboBox StatuscomboBox;
        private Button AddButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox CategorycomboBox;
        private Label label5;
        private TextBox otherTextbox;
        private Label otherlabel;
        private Button button1;
    }
}