using Microsoft.EntityFrameworkCore;

namespace handbook.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Post[] postsToSeed = new Post[3];
            postsToSeed[0] = new Post() { Id = 1, Title = "Post1", Content = "This is the Post1 content." };
            postsToSeed[1] = new Post() { Id = 2, Title = "Post2", Content = "This is the Post2 content." };
            postsToSeed[2] = new Post() { Id = 3, Title = "Post3", Content = "This is the Post3 content." };

            modelBuilder.Entity<Post>().HasData(postsToSeed);
        }
    }
}