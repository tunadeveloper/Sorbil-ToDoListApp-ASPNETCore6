using Microsoft.EntityFrameworkCore;

namespace YapilacaklarListesi.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TUNA\\SQLEXPRESS;database=YapilacaklarListesi;Integrated Security=True");
        }

        public DbSet<YapilacakGorev> YapilacakGorevs { get; set; }
    }
}
