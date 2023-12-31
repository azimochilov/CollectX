﻿using CollectX.Domain.Commons;
using CollectX.Domain.Enums;

namespace CollectX.Domain.Entities;
public class Collection : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Topic Topic { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
}
