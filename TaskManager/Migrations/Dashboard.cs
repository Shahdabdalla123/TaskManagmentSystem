using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace TaskManager
{
    public partial class Dashboard : Form
    {
        private PersonDetails _loggedInUser;
        private LiveCharts.WinForms.PieChart pieChart;

        public Dashboard(PersonDetails user)
        {
            InitializeComponent();
            _loggedInUser = user;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Welcome.Text = $"Welcome, {_loggedInUser.Name}!";

            var chartWidth = 350;
            var chartHeight = 440;

            pieChart = new LiveCharts.WinForms.PieChart
            {
                Size = new System.Drawing.Size(chartWidth, chartHeight),
                Location = new System.Drawing.Point(
                    (this.ClientSize.Width - chartWidth) / 2 - 10,
                    (this.ClientSize.Height - chartHeight) / 2 + 30
                )
            };

            Controls.Add(pieChart);
            LoadTaskData();
        }
        private void LoadTaskData()
        {
            using (var context = new TaskManagerDB())
            {
                var tasks = context.Task.Where(t => t.userId == _loggedInUser.Id).ToList();

                if (!tasks.Any())
                {
                    pieChart.Visible = false;
                    NoChartAvailableLabel.Visible = true;
                    return;
                }


                pieChart.Visible = true;
                var groupedTasks = tasks.GroupBy(t => t.Status).Select(g => new { Status = g.Key, Count = g.Count() })
                                        .ToList();
                NumCompleted.Text = groupedTasks.Where(t => t.Status.Equals("completed", StringComparison.OrdinalIgnoreCase)).Sum(t => t.Count).ToString();
                NumCanceled.Text = groupedTasks.Where(t => t.Status.Equals("canceled", StringComparison.OrdinalIgnoreCase)).Sum(t => t.Count).ToString();
                NumPending.Text = groupedTasks.Where(t => t.Status.Equals("pending", StringComparison.OrdinalIgnoreCase)).Sum(t => t.Count).ToString();
                int totalTasks = tasks.Count;
                pieChart.Series = new SeriesCollection();

                foreach (var group in groupedTasks)
                {
                    System.Windows.Media.Brush color;
                    switch (group.Status.ToLower())
                    {
                        case "completed":
                            color = System.Windows.Media.Brushes.Green;
                            break;
                        case "pending":
                            color = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 214, 90));
                            break;
                        case "canceled":
                            color = System.Windows.Media.Brushes.Red;
                            break;
                        default:
                            color = System.Windows.Media.Brushes.Gray;
                            break;
                    }

                    double percentage = (double)group.Count / totalTasks * 100;

                    pieChart.Series.Add(new PieSeries
                    {
                        Title = group.Status,
                        Values = new ChartValues<double> { percentage },
                        DataLabels = true,
                        LabelPoint = chartPoint => $"{group.Status}: {chartPoint.Y:F2}%",
                        Fill = color
                    });
                }
            }
        }


        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddNewTask_Click(object sender, EventArgs e)
        {
            Addtask Add = new Addtask(_loggedInUser);
            Add.Show();
            this.Hide();
        }

        private void EditTask_Click(object sender, EventArgs e)
        {
            EditForm Edit = new EditForm(_loggedInUser);
            Edit.Show();
            this.Hide();
        }

        private void RemoveTask_Click(object sender, EventArgs e)
        {
            RemoveTask R = new RemoveTask(_loggedInUser);
            R.Show();
            this.Hide();
        }

        private void TaskDetails_Click(object sender, EventArgs e)
        {
            TaskDetails D = new TaskDetails(_loggedInUser);
            D.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void FilterTask_Click(object sender, EventArgs e)
        {
            Filter f=new Filter(_loggedInUser);
            f.Show();
            this.Hide();
        }
    }
}
