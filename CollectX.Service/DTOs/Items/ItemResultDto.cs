using CollectX.Domain.Entities;

namespace CollectX.Service.DTOs.Items;
public class ItemResultDto
{
    public string Name { get; set; }
    public List<string> Tags { get; set; }
    public List<CustomField> CustomFields { get; set; }
    public List<Like> Likes { get; set; }
    public List<Comment> Comments { get; set; }
    public long UserId { get; set; }
}
