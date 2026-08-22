

namespace Lokar.Models
{
  public class CarModel
  {
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Brand { get; set; } = string.Empty;

    public int Year { get; set; }

    public string Color { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Transmission { get; set; } = string.Empty;

    public string FuelType { get; set; } = string.Empty;

    public int Seats { get; set; }

    public decimal DailyRate { get; set; }
  }
}
