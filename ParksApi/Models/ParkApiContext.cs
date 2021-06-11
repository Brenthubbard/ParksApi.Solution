using Microsoft.EntityFrameworkCore;



namespace ParksApi.Models
{
  public class ParkApiContext : DbContext
  {
    public ParkApiContext(DbContextOptions<ParkApiContext> options)
    : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
      .HasData(
        new Park { ParkId = 1, Name = "Yellowstone", SqMiles = 3471, State = "Wyoming and Idaho" },
        new Park { ParkId = 2, Name = "Arches National Park", SqMiles = 120, State = "Utah" },
        new Park { ParkId = 3, Name = "Yosemite National Park", SqMiles = 1169, State = "California" },
        new Park { ParkId = 4, Name = "Glacier National Park", SqMiles = 1583, State = "Montana" },
        new Park { ParkId = 5, Name = "Canyonlands National Park", SqMiles = 527, State = "Utah" }
      );
    }
    public DbSet<Park> Parks { get; set; }
  }
}