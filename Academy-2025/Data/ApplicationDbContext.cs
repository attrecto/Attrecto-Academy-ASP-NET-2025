using Microsoft.EntityFrameworkCore;

namespace Academy_2025.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string DbPath;

        public ApplicationDbContext()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            DbPath = Path.Join(path, "academy.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={DbPath}");

        public DbSet<User> Users { get; set; }
    }
}
