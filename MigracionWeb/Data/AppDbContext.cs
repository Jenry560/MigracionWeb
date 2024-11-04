

using Microsoft.EntityFrameworkCore;
using MigracionWeb.Models;

namespace MigracionWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Detencion> Detenciones { get; set; }
    }
}