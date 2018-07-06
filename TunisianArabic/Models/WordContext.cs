using Microsoft.EntityFrameworkCore;

namespace TunisianArabic.Models
{
    public class WordContext : DbContext
    {
        public WordContext(DbContextOptions<WordContext> options)
                : base(options)
        {
        }

        public DbSet<Word> Word { get; set; }
    }
}

