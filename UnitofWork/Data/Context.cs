using Microsoft.EntityFrameworkCore;

namespace UnitOfWork.Data;

public class Context:DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }
    
    // Tell EntityCore to create this table if not exist
    // public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }

}