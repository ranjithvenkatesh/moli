using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moli.api.Models
{
  public class UserContext : DbContext
  {
    public UserContext(DbContextOptions options)
            : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
  }
}
