using System.ComponentModel.DataAnnotations;

namespace RiotGamesApi.Core.Entities.shared;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
    //current creted time
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }
    public string? DeletedBy { get; set; }
    public string? UpdatedBy { get; set; }
    public string? CreatedBy { get; set; }
}