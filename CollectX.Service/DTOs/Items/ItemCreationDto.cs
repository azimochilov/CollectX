using CollectX.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace CollectX.Service.DTOs.Items;
public class ItemCreationDto
{
    [Required(ErrorMessage = "Name")]
    public string Name { get; set; }
    public List<string> Tags { get; set; }
    public List<CustomField> CustomFields { get; set; }
    public List<Like> Likes { get; set; }
    public List<Comment> Comments { get; set; }
    public long UserId { get; set; }
}
