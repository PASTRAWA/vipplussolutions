using Microsoft.EntityFrameworkCore;

namespace vipplussolution.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tours> Turlar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=vipPlus;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
