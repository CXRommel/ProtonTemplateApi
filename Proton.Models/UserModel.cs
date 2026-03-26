namespace Proton.Models;

public class UserModel
{
    public long Id { get; set; }
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;


    public ICollection<SchoolModel> Schools { get; set; }
}