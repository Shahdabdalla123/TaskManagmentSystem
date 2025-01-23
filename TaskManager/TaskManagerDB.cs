using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TaskManager
{
    public class TaskManagerDB : DbContext
    {
        public DbSet<PersonDetails> PersonDetails { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<Taskcategory> Taskcategory { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8T22NI1\\MSSQLSERVER02;Database=TaskManager;Trusted_Connection=True;TrustServerCertificate=True");

        }
    }
}
