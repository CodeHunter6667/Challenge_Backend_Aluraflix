using Aluraflix.Models;
using Microsoft.EntityFrameworkCore;

namespace Aluraflix.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public AppDbContext()
        {   
        }

        public DbSet<Videos>? Videos { get; set; }
    }
}
