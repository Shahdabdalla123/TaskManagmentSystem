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
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TaskManager
{
    public partial class EditForm : Form
    {
        TaskManagerDB DB = new TaskManagerDB();
        private PersonDetails _loggedInUser;
        private Taskcategory categoryName;

        public void ComboBoxesData()
        {
            var priorities = new List<string> { "High", "Medium", "Low" };
            var Status = new List<string> { "Pending", "Completed", "Canceled" };
            PrioritycomboBox.DataSource = priorities;
            PrioritycomboBox.SelectedIndex = -1;
            StatuscomboBox.DataSource = Status;
            StatuscomboBox.SelectedIndex = -1;
            var categories = DB.Taskcategory.Select(c => c.Name).ToList();
            CategorycomboBox.Items.AddRange(categories.ToArray());
            CategorycomboBox.Items.Add("Other");
            CategorycomboBox.SelectedIndex = -1;

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

                dataGridView.DataSource = taskNames;
            }

        }
        public EditForm(PersonDetails user)
        {
            InitializeComponent();
            _loggedInUser = user;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            Data();
            button2.Text = "←";
            ComboBoxesData();


        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
                NametextBox.Text = row.Cells[2].Value.ToString();
                dateTimePicker.Text = row.Cells[3].Value.ToString();
                PrioritycomboBox.Text = row.Cells[4].Value.ToString();
                StatuscomboBox.Text = row.Cells[5].Value.ToString();
                CategorycomboBox.Text = row.Cells[6].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPriority = PrioritycomboBox.SelectedItem.ToString();
                var selectedStatus = StatuscomboBox.SelectedItem.ToString();
                DateTime selectedDate = dateTimePicker.Value;
                string selectedCategory = CategorycomboBox.SelectedItem.ToString();
                var taskName = NametextBox.Text;

                if (string.IsNullOrEmpty(taskName))
                {
                    MessageBox.Show("Task name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(selectedPriority))
                {
                    MessageBox.Show("Please select a Priority", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(selectedStatus))
                {
                    MessageBox.Show("Please select a Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(selectedCategory))
                {
                    MessageBox.Show("Please select a category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (selectedCategory == "Other")
                {
                    string newCategoryName = othertextBox1.Text;

                    if (string.IsNullOrEmpty(newCategoryName))
                    {
                        MessageBox.Show("Please enter a name for the new category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Taskcategory newCategory = new Taskcategory
                    {
                        Name = newCategoryName
                    };

                    DB.Taskcategory.Add(newCategory);
                    DB.SaveChanges();
                    categoryName = newCategory;
                }
                else
                {
                    categoryName = DB.Taskcategory.FirstOrDefault(c => c.Name == selectedCategory);
                }
                if (dataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a task to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int taskId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["TaskID"].Value);
                var taskToUpdate = DB.Task.FirstOrDefault(t => t.Id == taskId);
                if (taskToUpdate == null)
                {
                    MessageBox.Show("Task not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (selectedDate.Date != taskToUpdate.Deadline.Date)
                {
                    if (selectedDate.Date <= DateTime.Now.Date)
                    {
                        MessageBox.Show("The deadline cannot be in the past", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    taskToUpdate.Deadline = selectedDate; 
                }

                taskToUpdate.Name = taskName;
                taskToUpdate.Deadline = selectedDate;
                taskToUpdate.Priority = selectedPriority;
                taskToUpdate.Status = selectedStatus;
                taskToUpdate.CategoryId = categoryName.Id;
                DB.SaveChanges();
                Data();
                MessageBox.Show("Task Updated SuccessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard dash = new Dashboard(_loggedInUser);
                dash.Show();
                this.Hide();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CategorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategorycomboBox.SelectedItem != null && CategorycomboBox.SelectedItem.ToString() == "Other")
            {
                otherLabel.Visible = true;
                othertextBox1.Visible = true;
            }
            else
            {
                otherLabel.Visible = false;
                othertextBox1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(_loggedInUser);
            dash.Show();
            this.Hide();
        }
    }
}
