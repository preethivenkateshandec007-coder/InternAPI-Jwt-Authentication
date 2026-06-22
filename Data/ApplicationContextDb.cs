using InternApiJwtAuthentication.Models;
using Microsoft.EntityFrameworkCore;

namespace InternApiJwtAuthentication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
    }
}