using Microsoft.EntityFrameworkCore;

namespace BookAPI.Model
{
    public class WriterContext : DbContext
    {
        public WriterContext(DbContextOptions<WriterContext> options): base(options) 
        {

        }

        DbSet<Writer> Writers { get; set; }
    }
}
