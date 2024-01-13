global using Microsoft.EntityFrameworkCore;
using webAPI.Models;

namespace webAPI.Data
{
    public class Context : DbContext
    {
        public static string serverName { get; set; } = "";
        public Context(DbContextOptions<Context> options)
        {
             
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer($"Server={serverName}; Database=DenemeMusicDb; Trusted_Connection=true; TrustServerCertificate=True");
        }

        public DbSet<Music> musics { get; set; }
    }
}
