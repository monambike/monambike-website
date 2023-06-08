using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Visibility
{
    public int VisibilityId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Post> Posts { get; } = new List<Post>();
}
