namespace Proton.Models;

public class UserModel
{
    public int Id { get; set; }
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
}