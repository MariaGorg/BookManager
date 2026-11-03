using Microsoft.EntityFrameworkCore;

namespace BookManager.Models
{
    public class LibraryContext: DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }
        public DbSet<Books> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Books>()
                .HasIndex(b => b.GoogleBookId)
                .IsUnique()
                .HasFilter("[GoogleBookId] IS NOT NULL");
        }
    }

}
