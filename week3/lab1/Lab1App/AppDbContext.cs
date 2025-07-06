using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;Encrypt=False;");

    }
}
