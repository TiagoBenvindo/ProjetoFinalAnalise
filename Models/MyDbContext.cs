using Microsoft.EntityFrameworkCore;

namespace ProjetoFinalAnalise.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<department> department { get; set; }
        public DbSet<salesRecord> salesRecord { get; set; }
        public DbSet<seller> seller { get; set; }
    }
}