namespace Mercury.Domain.Entities;

public class User
{
  public int Id { get; set; }
  public string Lastname { get; set; } = string.Empty;
  public string Firstname { get; set; } = string.Empty;
  public string Email { get; set; } = string.Empty;
  public string PasswordHash { get; set; } = string.Empty;
}
