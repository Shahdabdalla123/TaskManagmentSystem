using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TaskManager
{
    public partial class Signup : Form
    {
        TaskManagerDB DB = new TaskManagerDB();
        private bool isPasswordVisible = false;
        public Signup()
        {
            InitializeComponent();
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(SignUpUserNameTextBox.Text.Trim()))
            {
                MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (string.IsNullOrEmpty(EmailTextBox.Text.Trim()))
            {
                MessageBox.Show("Please enter an email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (string.IsNullOrEmpty(passwordSignUpTextBox.Text.Trim()))
            {
                MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                var UserName = SignUpUserNameTextBox.Text;
                var Email = EmailTextBox.Text;
                var Password = passwordSignUpTextBox.Text;
                PersonDetails userr = new PersonDetails()
                {
                    Name = UserName,
                    Email = Email,
                    Password = Password,

                };
                DB.Add(userr);
                DB.SaveChanges();
                MessageBox.Show("User Registered SuccessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 signInForm = new Form1();
                signInForm.Show();
                this.Hide();
            }
        }

        private void passwordSignUpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
