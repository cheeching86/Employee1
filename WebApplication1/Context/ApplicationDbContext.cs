using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>contextOptions) 
            : base(contextOptions)
        { 

        }

        public DbSet<Employee> Employees { get; set; }

    }


}
