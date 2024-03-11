using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RiotGamesApi.Core.Entities.shared;

namespace RiotGamesApi.Core.Entities;

public class User : BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public required Guid UserId { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
}