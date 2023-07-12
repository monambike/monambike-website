﻿using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Tag
{
    public int TagId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Post> Posts { get; } = new List<Post>();
}
