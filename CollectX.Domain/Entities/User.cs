﻿using CollectX.Domain.Commons;

namespace CollectX.Domain.Entities;
public class User : Auditable
{
    public string FirstName { get; set; }    
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
