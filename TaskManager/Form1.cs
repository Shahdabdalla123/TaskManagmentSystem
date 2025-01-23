using Microsoft.VisualBasic.ApplicationServices;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        TaskManagerDB DB = new TaskManagerDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var UserName = UserNameTextBox.Text;
            var password = passwordTextBox.Text;
            var Result = DB.PersonDetails.Where(s => (s.Name == UserName) & s.Password == password).FirstOrDefault();
            if (Result == null)
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard W = new Dashboard(Result);
                W.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup SU = new Signup();
            SU.Show();
            this.Hide();
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Donthaveaccount_Click(object sender, EventArgs e)
        {

        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
