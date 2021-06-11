using Microsoft.EntityFrameworkCore;



namespace ParksApi.Models
{
  public class ParkApiContext : DbContext
  {
    public ParkApiContext(DbContextOptions<ParkApiContext> options)
    : base(options)
    {
    }
    public DbSet<Park> Parks { get; set; }
  }
}