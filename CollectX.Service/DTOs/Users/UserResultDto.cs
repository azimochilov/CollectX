using System.ComponentModel;

namespace CollectX.Service.DTOs.Users;
public class UserResultDto
{
    public long Id { get; set; }

    [DisplayName("First Name")]
    public string FirstName { get; set; }

    [DisplayName("LastName")]
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}
