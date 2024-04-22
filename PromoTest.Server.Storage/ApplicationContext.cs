using Microsoft.EntityFrameworkCore;
using PromoTest.Server.Storage.Models;

namespace PromoTest.Server.Storage
{
    public class ApplicationContext: DbContext
    {
        public static string ConnectionString = "Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=postgres";

        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }
    }
}
