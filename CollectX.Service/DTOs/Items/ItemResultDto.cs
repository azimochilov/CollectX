using CollectX.Domain.Entities;

namespace CollectX.Service.DTOs.Items;
public class ItemResultDto
{
    public string Name { get; set; }
    public List<string> Tags { get; set; }
    public long UserId { get; set; }
}
