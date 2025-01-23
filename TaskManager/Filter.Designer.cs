namespace TaskManager
{
    partial class Filter
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
            StatuscomboBox1 = new ComboBox();
            DeadlinecomboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ProritycomboBox3 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // StatuscomboBox1
            // 
            StatuscomboBox1.BackColor = Color.Snow;
            StatuscomboBox1.FormattingEnabled = true;
            StatuscomboBox1.Location = new Point(122, 147);
            StatuscomboBox1.Name = "StatuscomboBox1";
            StatuscomboBox1.Size = new Size(151, 28);
            StatuscomboBox1.TabIndex = 0;
            // 
            // DeadlinecomboBox2
            // 
            DeadlinecomboBox2.BackColor = Color.Snow;
            DeadlinecomboBox2.FormattingEnabled = true;
            DeadlinecomboBox2.Location = new Point(420, 147);
            DeadlinecomboBox2.Name = "DeadlinecomboBox2";
            DeadlinecomboBox2.Size = new Size(151, 28);
            DeadlinecomboBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(391, 48);
            label1.Name = "label1";
            label1.Size = new Size(147, 33);
            label1.TabIndex = 2;
            label1.Text = "Filter Task";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(312, 152);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 3;
            label2.Text = "Deadline";
            label2.Click += label2_Click;
            // 
            // ProritycomboBox3
            // 
            ProritycomboBox3.BackColor = Color.Snow;
            ProritycomboBox3.FormattingEnabled = true;
            ProritycomboBox3.Location = new Point(717, 147);
            ProritycomboBox3.Name = "ProritycomboBox3";
            ProritycomboBox3.Size = new Size(151, 28);
            ProritycomboBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 152);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 5;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(611, 152);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 6;
            label4.Text = "Priority";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(138, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(609, 245);
            dataGridView1.TabIndex = 7;
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
            button1.Location = new Point(777, 430);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 8;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.MistyRose;
            button2.FlatAppearance.MouseDownBackColor = Color.MistyRose;
            button2.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.LightCoral;
            button2.Location = new Point(12, 48);
            button2.Name = "button2";
            button2.Size = new Size(94, 49);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Filter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(919, 496);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ProritycomboBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DeadlinecomboBox2);
            Controls.Add(StatuscomboBox1);
            Name = "Filter";
            Text = "Filter";
            FormClosing += Filter_FormClosing;
            Load += Filter_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox StatuscomboBox1;
        private ComboBox DeadlinecomboBox2;
        private Label label1;
        private Label label2;
        private ComboBox ProritycomboBox3;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}