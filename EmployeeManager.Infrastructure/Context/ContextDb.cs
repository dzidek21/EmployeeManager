using EmployeeManager.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.Infrastructure.Context
{
    public class ContextDb : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProjectHistory> EmployeeProjectHistories { get; set; }
        public ContextDb(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().
                HasMany(x => x.ProjectsHistory).
                WithOne(x => x.Employee).
                HasForeignKey(x => x.EmployeeId);
            modelBuilder.Entity<Project>().
                HasMany(x => x.Employees).
                WithOne(x => x.CurrentProject).
                HasForeignKey(x => x.CurrentProjectId);
                
                
                
            base.OnModelCreating(modelBuilder);
        }
    }
}
