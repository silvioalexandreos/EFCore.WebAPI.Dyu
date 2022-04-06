using EFCore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebAPI.Data
{
    public class HeroiContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
            => builder.UseSqlServer("Server=localhost,1433;Database=DbHeroi;User ID=sa;Password=1q2w3e4r@#$; TrustServerCertificate = True");

    }
}
