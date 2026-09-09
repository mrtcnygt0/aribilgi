using Microsoft.EntityFrameworkCore;

namespace EntityCodeFirst2.Models
{
    public class OyunDBContext:DbContext
    {
        public OyunDBContext()
        {
            
        }

        public OyunDBContext(DbContextOptions<OyunDBContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Oyuncu> Oyuncular { get; set; }
        public virtual DbSet<Skor> Skorlar { get; set; }
        public virtual DbSet<Envanter> Envanterler { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Server=MERT\\SQLEXPRESS;Database=OyunDB;User ID=OzgurZaman;Password=2119;Trust Server Certificate=True");

    }
}
