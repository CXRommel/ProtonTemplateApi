using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proton.Repositories.Entities;

[Table(name: "Users")]
public class UserEntity
{
    [Key]
    [Column(name: "UserId")]
    public int Id { get; set; }
    [MaxLength(length: 50)]
    public string FirstName { get; init; } = string.Empty;
    [MaxLength(length: 100)]
    public string LastName { get; init; } = string.Empty;
}