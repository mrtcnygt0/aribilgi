using Microsoft.EntityFrameworkCore;

namespace EntityCodeFirst.Models
{
    public class HastaneDBContext : DbContext
    {
        public HastaneDBContext()
        {

        }

        public HastaneDBContext(DbContextOptions<HastaneDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Hasta> Hastalar { get; set; }
        public virtual DbSet<Doktor> Doktorlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Server=MERT\\SQLEXPRESS;Database=HastaneDB;User ID=OzgurZaman;Password=2119;Trust Server Certificate=True");

        // add-migration HastaneDB
    }
}
