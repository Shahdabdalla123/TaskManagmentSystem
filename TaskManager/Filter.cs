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
    public partial class Filter : Form
    {
        TaskManagerDB DB = new TaskManagerDB();
        private PersonDetails _loggedInUser;
        public Filter(PersonDetails user)
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
                    Deadline = t.Deadline.Date,
                    Priority = t.Priority,
                    Status = t.Status,
                    Category = t.Category.Name,

                }).Distinct().ToList();

                dataGridView1.DataSource = taskNames;
            }

        }
        public void ComboBoxesData()
        {
            var priorities = DB.Task.Select(c => c.Priority).Distinct().ToList();
            foreach (var p in priorities)
            {
                ProritycomboBox3.Items.Add(p);
            }
            var Status = DB.Task.Select(c => c.Status).Distinct().ToList();
            foreach (var S in Status)
            {
                StatuscomboBox1.Items.Add(S);
            }

            var deadlines = DB.Task.Select(c => c.Deadline.Date).Distinct().ToList();
            foreach (var deadline in deadlines)
            {
                DeadlinecomboBox2.Items.Add(deadline.ToString("dd-MM-yyyy"));
            }
            ProritycomboBox3.SelectedIndex = -1;
            StatuscomboBox1.SelectedIndex = -1;
            DeadlinecomboBox2.SelectedIndex = -1;

        }

        private void Filter_Load(object sender, EventArgs e)
        {
            Data();
            button2.Text = "←";
            ComboBoxesData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Filter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedPriority = ProritycomboBox3.SelectedItem?.ToString();
            var selectedStatus = StatuscomboBox1.SelectedItem?.ToString();
            var selectedDeadline = DeadlinecomboBox2.SelectedItem?.ToString();
            DateTime? parsedDeadline = null;
            if (!string.IsNullOrEmpty(selectedDeadline))
            {
                parsedDeadline = DateTime.ParseExact(selectedDeadline, "dd-MM-yyyy", null);
            }

            var filteredTasks = DB.PersonDetails.Include(t => t.Tasks).ThenInclude(t => t.Category)
                                 .Where(p => p.Id == _loggedInUser.Id)
                                 .SelectMany(p => p.Tasks)
                                 .Where(t =>
                                     (string.IsNullOrEmpty(selectedPriority) || t.Priority == selectedPriority) &&
                                     (string.IsNullOrEmpty(selectedStatus) || t.Status == selectedStatus) &&
                                     (!parsedDeadline.HasValue || t.Deadline.Date == parsedDeadline.Value)
                                 )
                                 .Select(t => new
                                 {
                                     TaskID = t.Id,
                                     TaskName = t.Name,
                                     Deadline = t.Deadline.Date,
                                     Priority = t.Priority,
                                     Status = t.Status,
                                     Category = t.Category.Name,
                                 })
                                 .ToList();


            dataGridView1.DataSource = filteredTasks;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(_loggedInUser);
            dash.Show();
            this.Hide();
        }
    }
}
