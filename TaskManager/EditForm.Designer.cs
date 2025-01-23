namespace TaskManager
{
    partial class EditForm
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
            dataGridView = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            NametextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker = new DateTimePicker();
            StatuscomboBox = new ComboBox();
            PrioritycomboBox = new ComboBox();
            CategorycomboBox = new ComboBox();
            othertextBox1 = new TextBox();
            CategoryLabel = new Label();
            otherLabel = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.Snow;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(167, 281);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(544, 250);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
            dataGridView.CellMouseClick += dataGridView_CellMouseClick;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(761, 489);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(405, 44);
            label1.Name = "label1";
            label1.Size = new Size(129, 33);
            label1.TabIndex = 2;
            label1.Text = "Edit Task";
            // 
            // NametextBox
            // 
            NametextBox.BackColor = Color.Snow;
            NametextBox.Location = new Point(148, 95);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(250, 27);
            NametextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 95);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 163);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 8;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(494, 95);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 9;
            label4.Text = "Deadline";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(494, 163);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 10;
            label5.Text = "Prioriry";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(611, 95);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 11;
            // 
            // StatuscomboBox
            // 
            StatuscomboBox.FormattingEnabled = true;
            StatuscomboBox.Location = new Point(148, 158);
            StatuscomboBox.Name = "StatuscomboBox";
            StatuscomboBox.Size = new Size(250, 28);
            StatuscomboBox.TabIndex = 12;
            // 
            // PrioritycomboBox
            // 
            PrioritycomboBox.FormattingEnabled = true;
            PrioritycomboBox.Location = new Point(611, 158);
            PrioritycomboBox.Name = "PrioritycomboBox";
            PrioritycomboBox.Size = new Size(250, 28);
            PrioritycomboBox.TabIndex = 13;
            // 
            // CategorycomboBox
            // 
            CategorycomboBox.FormattingEnabled = true;
            CategorycomboBox.Location = new Point(148, 225);
            CategorycomboBox.Name = "CategorycomboBox";
            CategorycomboBox.Size = new Size(250, 28);
            CategorycomboBox.TabIndex = 14;
            CategorycomboBox.SelectedIndexChanged += CategorycomboBox_SelectedIndexChanged;
            // 
            // othertextBox1
            // 
            othertextBox1.Location = new Point(611, 225);
            othertextBox1.Name = "othertextBox1";
            othertextBox1.Size = new Size(250, 27);
            othertextBox1.TabIndex = 15;
            othertextBox1.Visible = false;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryLabel.Location = new Point(36, 229);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(87, 23);
            CategoryLabel.TabIndex = 16;
            CategoryLabel.Text = "Category";
            CategoryLabel.Click += label6_Click;
            // 
            // otherLabel
            // 
            otherLabel.AutoSize = true;
            otherLabel.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otherLabel.Location = new Point(494, 229);
            otherLabel.Name = "otherLabel";
            otherLabel.Size = new Size(59, 23);
            otherLabel.TabIndex = 17;
            otherLabel.Text = "Other";
            otherLabel.Visible = false;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.MistyRose;
            button2.FlatAppearance.MouseDownBackColor = Color.MistyRose;
            button2.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.LightCoral;
            button2.Location = new Point(29, 32);
            button2.Name = "button2";
            button2.Size = new Size(94, 49);
            button2.TabIndex = 18;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(919, 553);
            Controls.Add(button2);
            Controls.Add(otherLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(othertextBox1);
            Controls.Add(CategorycomboBox);
            Controls.Add(PrioritycomboBox);
            Controls.Add(StatuscomboBox);
            Controls.Add(dateTimePicker);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NametextBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView);
            Name = "EditForm";
            Text = "EditForm";
            FormClosing += EditForm_FormClosing;
            Load += EditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button button1;
        private Label label1;
        private TextBox NametextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker;
        private ComboBox StatuscomboBox;
        private ComboBox PrioritycomboBox;
        private ComboBox CategorycomboBox;
        private TextBox othertextBox1;
        private Label CategoryLabel;
        private Label otherLabel;
        private Button button2;
    }
}