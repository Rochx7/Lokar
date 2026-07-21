namespace Lokar.Models
{
  public class CnhModel
  {
    public string Number { get; set; } = string.Empty;

    public CnhCategory Category { get; set; }

    public DateTime ExpirationDate { get; set; }

    public bool IsSuspended { get; set; }


    public bool IsValid()
    {
      return !IsSuspended &&
             ExpirationDate >= DateTime.UtcNow;
    }
  }
}
