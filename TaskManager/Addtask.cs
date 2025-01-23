using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace TaskManager
{
    public partial class Addtask : Form

    {
        TaskManagerDB DB = new TaskManagerDB();
        private PersonDetails _loggedInUser;
        private Taskcategory categoryName;
        public Addtask(PersonDetails user)
        {
            InitializeComponent();
            _loggedInUser = user;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Addtask_Load_1(object sender, EventArgs e)
        {
            PrioritycomboBox.Items.Add("High");
            PrioritycomboBox.Items.Add("Medium");
            PrioritycomboBox.Items.Add("Low");
            StatuscomboBox.Items.Add("Pending");
            StatuscomboBox.Items.Add("Completed");
            StatuscomboBox.Items.Add("Canceled");
            var categories = DB.Taskcategory.Select(c => c.Name).ToList();
            CategorycomboBox.Items.AddRange(categories.ToArray());
            CategorycomboBox.Items.Add("Other");
            button1.Text = "←";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {


            var selectedPriority = PrioritycomboBox.SelectedItem.ToString();
            var selectedstatus = StatuscomboBox.SelectedItem.ToString();
            DateTime selectedDate = dateTimePicker.Value;
            string selectedCategory = CategorycomboBox.SelectedItem.ToString();
            var taskName = NameTextbox.Text;
            if (selectedDate < DateTime.Now.Date)
            {
                MessageBox.Show("The deadline cannot be in the past", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (string.IsNullOrEmpty(selectedPriority))
            {
                MessageBox.Show("Please select a priority", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(selectedstatus))
            {
                MessageBox.Show("Please select a Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("Please Write Task Name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedCategory == "Other")
            {
                string newCategoryName = otherTextbox.Text;

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
            Task newTask = new Task()
            {
                Name = taskName,
                Deadline = selectedDate,
                Priority = selectedPriority,
                Status = selectedstatus,
                CreatedDate = DateTime.Now,
                userId = _loggedInUser.Id,
                CategoryId = categoryName.Id,
            };
            DB.Add(newTask);
            DB.SaveChanges();
            MessageBox.Show("Task Added SuccessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dashboard dash = new Dashboard(_loggedInUser);
            dash.Show();
            this.Hide();


        }

        private void Addtask_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CategorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategorycomboBox.SelectedItem != null && CategorycomboBox.SelectedItem.ToString() == "Other")
            {
                otherlabel.Visible = true;
                otherTextbox.Visible = true;
            }
            else
            {
                otherlabel.Visible = false;
                otherTextbox.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(_loggedInUser);
            dash.Show();
            this.Hide();
        }
    }
}
