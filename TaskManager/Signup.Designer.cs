namespace TaskManager
{
    partial class Signup
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SignUpUserNameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            passwordSignUpTextBox = new TextBox();
            SignUpButton = new Button();
            UserName = new Label();
            Email = new Label();
            Password = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SignUpUserNameTextBox
            // 
            SignUpUserNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            SignUpUserNameTextBox.Location = new Point(640, 150);
            SignUpUserNameTextBox.Name = "SignUpUserNameTextBox";
            SignUpUserNameTextBox.Size = new Size(214, 27);
            SignUpUserNameTextBox.TabIndex = 0;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(640, 228);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(214, 27);
            EmailTextBox.TabIndex = 1;
            // 
            // passwordSignUpTextBox
            // 
            passwordSignUpTextBox.Location = new Point(640, 310);
            passwordSignUpTextBox.Name = "passwordSignUpTextBox";
            passwordSignUpTextBox.Size = new Size(214, 27);
            passwordSignUpTextBox.TabIndex = 2;
            passwordSignUpTextBox.UseSystemPasswordChar = true;
            passwordSignUpTextBox.TextChanged += passwordSignUpTextBox_TextChanged;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.LightCoral;
            SignUpButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            SignUpButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            SignUpButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            SignUpButton.FlatStyle = FlatStyle.Flat;
            SignUpButton.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SignUpButton.ForeColor = Color.White;
            SignUpButton.Location = new Point(754, 431);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(100, 41);
            SignUpButton.TabIndex = 3;
            SignUpButton.Text = "Register";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UserName.Location = new Point(511, 154);
            UserName.Name = "UserName";
            UserName.Size = new Size(97, 23);
            UserName.TabIndex = 4;
            UserName.Text = "UserName";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Email.Location = new Point(511, 232);
            Email.Name = "Email";
            Email.Size = new Size(58, 23);
            Email.TabIndex = 5;
            Email.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Password.Location = new Point(511, 314);
            Password.Name = "Password";
            Password.Size = new Size(91, 23);
            Password.TabIndex = 6;
            Password.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.Mobile_login;
            pictureBox1.Location = new Point(-3, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(681, 58);
            label1.Name = "label1";
            label1.Size = new Size(109, 33);
            label1.TabIndex = 8;
            label1.Text = "Sign Up";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(471, 398);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 9;
            label2.Text = "Already Have Account?";
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
            button1.Location = new Point(508, 431);
            button1.Name = "button1";
            button1.Size = new Size(100, 41);
            button1.TabIndex = 10;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(919, 496);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(UserName);
            Controls.Add(SignUpButton);
            Controls.Add(passwordSignUpTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(SignUpUserNameTextBox);
            Name = "Signup";
            Text = "Signup";
            FormClosing += Signup_FormClosing;
            Load += Signup_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox SignUpUserNameTextBox;
        private TextBox EmailTextBox;
        private TextBox passwordSignUpTextBox;
        private Button SignUpButton;
        private Label UserName;
        private Label Email;
        private Label Password;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}