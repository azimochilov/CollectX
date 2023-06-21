using CollectX.Domain.Commons;

namespace CollectX.Domain.Entities;
public class Item : Auditable
{
    public string Name { get; set; }
    public List<string> Tags { get; set; }
    public List<CustomField> CustomFields { get; set; }

}
