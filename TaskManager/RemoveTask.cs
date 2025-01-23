using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace TaskManager
{
    public partial class RemoveTask : Form
    {
        TaskManagerDB DB = new TaskManagerDB();
        private PersonDetails _loggedInUser;
        private Taskcategory categoryName;

        public RemoveTask(PersonDetails user)
        {
            InitializeComponent();
            _loggedInUser = user;
        }
        public void Data()
        {
            var AllData = DB.PersonDetails.Include(t => t.Tasks).ThenInclude(t => t.Category).FirstOrDefault(p => p.Id == _loggedInUser.Id);


            if (AllData != null)
            {
                var taskNames = AllData.Tasks.Select(t => new
                {
                    UserID = AllData.Id,
                    TaskID = t.Id,
                    TaskName = t.Name,
                    Deadline = t.Deadline,
                    Priority = t.Priority,
                    Status = t.Status,
                    Category = t.Category.Name,

                }).ToList();

                RemovedataGridView.DataSource = taskNames;
            }

        }
        private void RemoveTask_Load(object sender, EventArgs e)
        {
            Data();
            button2.Text= "←";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RemoveTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RemovedataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.RemovedataGridView.Rows[e.RowIndex];
                NametextBox.Text = row.Cells[2].Value.ToString();
                DeadlinetextBox.Text = row.Cells[3].Value.ToString();
                PriorirytextBox.Text = row.Cells[4].Value.ToString();
                StatustextBox.Text = row.Cells[5].Value.ToString();

                NametextBox.ReadOnly = true;
                DeadlinetextBox.ReadOnly = true;
                PriorirytextBox.ReadOnly = true;
                StatustextBox.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int taskId = Convert.ToInt32(RemovedataGridView.SelectedRows[0].Cells["TaskID"].Value);
            var taskToUpdate = DB.Task.FirstOrDefault(t => t.Id == taskId);
            if (taskToUpdate == null)
            {
                MessageBox.Show("Task not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DB.Remove(taskToUpdate);
                DB.SaveChanges();
                Data();
                MessageBox.Show("Task Deleted SuccessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard dash = new Dashboard(_loggedInUser);
                dash.Show();
                this.Hide();

            }
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(_loggedInUser);
            dash.Show();
            this.Hide();
        }
    }
}
