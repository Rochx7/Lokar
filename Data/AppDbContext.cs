

using Lokar.Models;
using Microsoft.EntityFrameworkCore;

namespace Lokar.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<CarModel> Cars { get; set; }
  }
}
