using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EvenimentDb> Evenimente => Set<EvenimentDb>();
        public DbSet<
    }
}