using Microsoft.EntityFrameworkCore;

namespace AspNetCoreToDoApi.Models
{
    // The database context is the main class that coordinates Entity Framework functionality for a data model
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
