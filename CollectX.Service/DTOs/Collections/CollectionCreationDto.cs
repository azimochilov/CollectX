using CollectX.Domain.Entities;
using CollectX.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CollectX.Service.DTOs.Collections;
public class CollectionCreationDto
{
    [Required(ErrorMessage = "Name")]
    public string Name { get; set; }
    public string Description { get; set; }
    [Required(ErrorMessage = "Topic")]
    public Topic Topic { get; set; }    
    public long UserId { get; set; }
}
