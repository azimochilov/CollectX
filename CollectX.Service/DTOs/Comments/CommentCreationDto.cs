using CollectX.Domain.Entities;

namespace CollectX.Service.DTOs.Comments;
public class CommentCreationDto
{
    public string Text { get; set; }
    public long ItemId { get; set; }    
    public long UserId { get; set; }    
}
