using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proton.Repositories.Entities;

[Table(name: "Users")]
public class UserEntity
{
    [Key]
    public long Id { get; set; }
    [MaxLength(length: 50)]
    public string FirstName { get; init; } = string.Empty;
    [MaxLength(length: 50)]
    public string LastName { get; init; } = string.Empty;
    [MaxLength(length: 200)]
    public string Email { get; set; } = string.Empty;

    public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
}