using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employee_project.Models;

namespace Employee_project.Data
{
    public class Employee_projectContext : DbContext
    {
        public Employee_projectContext (DbContextOptions<Employee_projectContext> options)
            : base(options)
        {
        }

        public DbSet<Employee_project.Models.Employee> Employee { get; set; } = default!;

        public DbSet<Employee_project.Models.Product>? Product { get; set; }
    }
}
