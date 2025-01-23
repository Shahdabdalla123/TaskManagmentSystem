using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public int userId { get; set; }
        public PersonDetails user { get; set; }
        public int CategoryId { get; set; }
        public Taskcategory Category { get; set; }
    }
}
