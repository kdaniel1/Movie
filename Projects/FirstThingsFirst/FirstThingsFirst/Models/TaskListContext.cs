using System;
using Microsoft.EntityFrameworkCore;

namespace FirstThingsFirst.Models
{
    public class TaskListContext : DbContext
    {
        public TaskListContext (DbContextOptions<TaskListContext> options) : base(options)
        {

        }
        public DbSet<TaskItem> Tasks { get; set; }
    }
}
