using InternshipProjectWork.Models;
using Microsoft.EntityFrameworkCore;

namespace InternshipProjectWork.Data
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<logindetails> Logindetails{ get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}
