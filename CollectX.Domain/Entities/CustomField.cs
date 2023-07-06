﻿using CollectX.Domain.Commons;

namespace CollectX.Domain.Entities;
public class CustomField : Auditable
{
    public string Name { get; set; }
    public string Value { get; set; } 
}
