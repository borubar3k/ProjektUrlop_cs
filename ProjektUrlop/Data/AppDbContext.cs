using Microsoft.EntityFrameworkCore;
using ProjektUrlop.Models;

namespace ProjektUrlop.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pracownik> pracownicy { get; set; } = null!;
        public DbSet<Urlop> urlopy {  get; set; } = null!;
        public DbSet<Logowania> logowania { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"");
        }
    }
}
