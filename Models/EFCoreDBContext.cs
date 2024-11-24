using Microsoft.EntityFrameworkCore;

namespace CrudAppDotnetTutorials.Models
{
    public class EFCoreDBContext:DbContext
    {
        public EFCoreDBContext(DbContextOptions<EFCoreDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
