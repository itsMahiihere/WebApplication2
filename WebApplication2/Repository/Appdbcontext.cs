using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;


namespace WebApplication2
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
