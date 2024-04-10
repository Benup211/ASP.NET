using Microsoft.EntityFrameworkCore;

namespace EFNET.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<EFNET.Models.WebUser>? WebUser { get; set; }
    }
}