
using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext()
        //{
        //}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {            
        }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property<DateTime>("CreatedDate");
            modelBuilder.Entity<Employee>().Property<DateTime>("UpdatedDate");
        }
        public DbSet<Employee> Employees { get; set;}
        public DbSet<Department> Departments { get; set; }
    }
}




