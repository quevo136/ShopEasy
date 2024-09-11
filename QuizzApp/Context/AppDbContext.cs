using Microsoft.EntityFrameworkCore;
using QuizzApp.Models;

namespace QuizzApp.Context
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Question> Questions { get; set; }
                   
    }
}
