using Microsoft.EntityFrameworkCore;

namespace moli.api.Models
{
  public class UserContext : DbContext
  {
    public UserContext(DbContextOptions options)
            : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<User>().HasData(new User
      {
        Id = 1,
        Email = "ranjithvenkatesh@hotmail.com"

      }, new User
      {
        Id = 2,
        Email = "ranjith.venkatesh@mossandlichens.com"        
      });
    }
  }
}
