using Microsoft.EntityFrameworkCore;
using Practical5C.Models;
namespace Practical5C.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Employee> Employee {  get; set; }
    }
}
