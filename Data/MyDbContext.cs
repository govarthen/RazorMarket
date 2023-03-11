using RazorMarket.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace RazorMarket.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

    }
}
