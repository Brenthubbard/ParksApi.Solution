



namespace ParksApi.Models
{
  public class ParksApi
  {
    public int ParkId { get; set; }
    [Required]
    public string Name { get; set; }
    public string State { get; set; }
    public int SqMiles { get; set; }
    
  }
}