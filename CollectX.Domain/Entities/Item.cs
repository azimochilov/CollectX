using CollectX.Domain.Commons;

namespace CollectX.Domain.Entities;
public class Item : Auditable
{
    public string Name { get; set; }
    public List<string> Tags { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
}
