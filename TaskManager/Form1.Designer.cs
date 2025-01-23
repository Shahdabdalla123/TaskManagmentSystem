namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            LogInButton = new Button();
            SignUpButtton = new Button();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            pictureBox1 = new PictureBox();
            Donthaveaccount = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(654, 149);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(214, 27);
            UserNameTextBox.TabIndex = 0;
            UserNameTextBox.TextChanged += UserNameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(654, 232);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(214, 27);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.LightCoral;
            LogInButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            LogInButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            LogInButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LogInButton.ForeColor = Color.White;
            LogInButton.Location = new Point(768, 307);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(100, 42);
            LogInButton.TabIndex = 2;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += button1_Click;
            // 
            // SignUpButtton
            // 
            SignUpButtton.BackColor = Color.LightCoral;
            SignUpButtton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            SignUpButtton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            SignUpButtton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            SignUpButtton.FlatStyle = FlatStyle.Flat;
            SignUpButtton.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SignUpButtton.ForeColor = Color.White;
            SignUpButtton.Location = new Point(502, 412);
            SignUpButtton.Name = "SignUpButtton";
            SignUpButtton.Size = new Size(100, 41);
            SignUpButtton.TabIndex = 3;
            SignUpButtton.Text = "SignUp";
            SignUpButtton.UseVisualStyleBackColor = false;
            SignUpButtton.Click += button2_Click;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(522, 153);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(97, 23);
            UserNameLabel.TabIndex = 4;
            UserNameLabel.Text = "UserName";
            UserNameLabel.Click += UserNameLabel_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(522, 236);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(91, 23);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources._3099609;
            pictureBox1.Location = new Point(-5, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(456, 493);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Donthaveaccount
            // 
            Donthaveaccount.AutoSize = true;
            Donthaveaccount.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Donthaveaccount.Location = new Point(475, 359);
            Donthaveaccount.Name = "Donthaveaccount";
            Donthaveaccount.Size = new Size(127, 20);
            Donthaveaccount.TabIndex = 7;
            Donthaveaccount.Text = "Create Account?";
            Donthaveaccount.Click += Donthaveaccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(708, 59);
            label1.Name = "label1";
            label1.Size = new Size(93, 33);
            label1.TabIndex = 8;
            label1.Text = "Log In";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(920, 487);
            Controls.Add(label1);
            Controls.Add(Donthaveaccount);
            Controls.Add(pictureBox1);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(SignUpButtton);
            Controls.Add(LogInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(UserNameTextBox);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserNameTextBox;
        private TextBox passwordTextBox;
        private Button LogInButton;
        private Button SignUpButtton;
        private Label UserNameLabel;
        private Label PasswordLabel;
        private PictureBox pictureBox1;
        private Label Donthaveaccount;
        private Label label1;
    }
}
