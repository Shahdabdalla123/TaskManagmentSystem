namespace TaskManager
{
    partial class RemoveTask
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
            label1 = new Label();
            RemovedataGridView = new DataGridView();
            button1 = new Button();
            NametextBox = new TextBox();
            StatustextBox = new TextBox();
            DeadlinetextBox = new TextBox();
            PriorirytextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)RemovedataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(377, 50);
            label1.Name = "label1";
            label1.Size = new Size(184, 33);
            label1.TabIndex = 0;
            label1.Text = "Remove Task ";
            label1.Click += label1_Click;
            // 
            // RemovedataGridView
            // 
            RemovedataGridView.BackgroundColor = Color.Snow;
            RemovedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RemovedataGridView.Location = new Point(163, 295);
            RemovedataGridView.Name = "RemovedataGridView";
            RemovedataGridView.RowHeadersWidth = 51;
            RemovedataGridView.Size = new Size(583, 233);
            RemovedataGridView.TabIndex = 1;
            RemovedataGridView.CellMouseClick += RemovedataGridView_CellMouseClick;
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
            button1.Location = new Point(771, 486);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 2;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(154, 131);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(249, 27);
            NametextBox.TabIndex = 3;
            NametextBox.TextChanged += NametextBox_TextChanged;
            // 
            // StatustextBox
            // 
            StatustextBox.Location = new Point(154, 213);
            StatustextBox.Name = "StatustextBox";
            StatustextBox.Size = new Size(249, 27);
            StatustextBox.TabIndex = 4;
            StatustextBox.TextChanged += textBox2_TextChanged;
            // 
            // DeadlinetextBox
            // 
            DeadlinetextBox.Location = new Point(622, 213);
            DeadlinetextBox.Name = "DeadlinetextBox";
            DeadlinetextBox.Size = new Size(249, 27);
            DeadlinetextBox.TabIndex = 5;
            // 
            // PriorirytextBox
            // 
            PriorirytextBox.Location = new Point(622, 131);
            PriorirytextBox.Name = "PriorirytextBox";
            PriorirytextBox.Size = new Size(249, 27);
            PriorirytextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 135);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 7;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 217);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 8;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(511, 135);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 9;
            label4.Text = "Priority";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(502, 217);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 10;
            label5.Text = "Deadline";
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.FlatAppearance.BorderColor = Color.MistyRose;
            button2.FlatAppearance.MouseDownBackColor = Color.MistyRose;
            button2.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.LightCoral;
            button2.Location = new Point(61, 38);
            button2.Name = "button2";
            button2.Size = new Size(94, 49);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // RemoveTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(919, 553);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PriorirytextBox);
            Controls.Add(DeadlinetextBox);
            Controls.Add(StatustextBox);
            Controls.Add(NametextBox);
            Controls.Add(button1);
            Controls.Add(RemovedataGridView);
            Controls.Add(label1);
            Name = "RemoveTask";
            Text = "Unicode: U+2190";
            FormClosing += RemoveTask_FormClosing;
            Load += RemoveTask_Load;
            ((System.ComponentModel.ISupportInitialize)RemovedataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView RemovedataGridView;
        private Button button1;
        private TextBox NametextBox;
        private TextBox StatustextBox;
        private TextBox DeadlinetextBox;
        private TextBox PriorirytextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}