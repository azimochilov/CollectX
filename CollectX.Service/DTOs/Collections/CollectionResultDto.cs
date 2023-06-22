using CollectX.Domain.Entities;
using CollectX.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CollectX.Service.DTOs.Collections;
public class CollectionResultDto
{    
    public string Name { get; set; }
    public string Description { get; set; }
    public Topic Topic { get; set; } 
    public long UserId { get; set; }
}
