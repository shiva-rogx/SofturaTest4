using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DetailsEmployee.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Shiva", Age = 22, Qualification = "Graduate", IsEmployeed = "Yes", NoticePeriod = "2 Months", CurrentCTC = 50000 });
        }
    }
}
