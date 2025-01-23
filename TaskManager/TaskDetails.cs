using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class TaskDetails : Form
    {
        TaskManagerDB DB = new TaskManagerDB();
        private PersonDetails _loggedInUser;
        private Taskcategory categoryName;
        public TaskDetails(PersonDetails user)
        {
            InitializeComponent();
            _loggedInUser = user;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TaskDetails_Load(object sender, EventArgs e)
        {
            button2.Text = "←";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var SearchValue = SearchtextBox.Text;
            var Result = DB.Task.Where(T => T.Name == SearchValue).Select(T => new { T.Name, T.Status, T.Deadline, T.Category, T.Priority }).FirstOrDefault();
            if (Result == null)
            {
                MessageBox.Show("Task not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                NameTextBox.Visible = true;
                StatusTextBox.Visible = true;
                PrioriryTextBox.Visible = true;
                DealineTextBox.Visible = true;
                CategoryIDTextBox.Visible = true;
                CategoryNameTextBox.Visible = true;
                NameTextBox.Text = Result.Name;
                StatusTextBox.Text = Result.Status;
                PrioriryTextBox.Text = Result.Priority;
                DealineTextBox.Text = Result.Deadline.ToString("dd-MM-yyyy");
                CategoryIDTextBox.Text = Result.Category.Id.ToString();
                CategoryNameTextBox.Text = Result.Category.Name;
            }

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaskDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(_loggedInUser);
            dash.Show();
            this.Hide();

        }
    }
}
