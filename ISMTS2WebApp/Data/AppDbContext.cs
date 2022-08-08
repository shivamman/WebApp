using ISMTS2WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ISMTS2WebApp.Data
{
  public class AppDbContext:DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options)
   : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
  }
}
