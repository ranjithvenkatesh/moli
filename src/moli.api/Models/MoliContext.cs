using Microsoft.EntityFrameworkCore;

namespace moli.api.Models
{
  public class MoliContext : DbContext
  {
    public MoliContext(DbContextOptions options)
            : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Audio> Audios { get; set; }
    public DbSet<Image> Images { get; set; }

    public DbSet<Test> Tests { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<User>().HasData(new User
      {
        Id = 1,
        Email = "ranjithvenkatesh@hotmail.com",
        Name = "Ranjith"
      }, new User
      {
        Id = 2,
        Email = "ranjith.venkatesh@mossandlichens.com",
        Name = "Venkatesh"
      });

      modelBuilder.Entity<Lesson>().HasData(new Lesson
      {
        Id = 1,
        Name = "Numbers"
      }, new Lesson
      {
        Id = 2,
        Name = "Days"
      });
    }
  }
}
