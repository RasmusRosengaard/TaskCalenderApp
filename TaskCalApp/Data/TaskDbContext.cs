using Microsoft.EntityFrameworkCore;
using TaskCalApp.Models;

namespace TaskCalApp.Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options)
        : base(options)
        {
        }
        
        public DbSet<TaskCalApp.Models.Task> Task { get; set; } = default!;
    }
}
