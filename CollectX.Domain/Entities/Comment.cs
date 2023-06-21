using CollectX.Domain.Commons;

namespace CollectX.Domain.Entities;
public class Comment : Auditable
{
    public string Text { get; set; }
    public long ItemId { get; set; }
    public Item Item { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }

}
