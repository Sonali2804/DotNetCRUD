using CRUDOPERATIONS.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CRUDOPERATIONS.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

       //  This will be the same name as table
        public DbSet<Employee> Employees { get; set; }
    }
}
