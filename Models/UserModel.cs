namespace Lokar.Models
{
  public class UserModel
  {
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public DateTime BirthDate { get; set; }

    public string Cpf { get; set; } = string.Empty;

    public CnhModel Cnh { get; set; } = new();
  }
}
