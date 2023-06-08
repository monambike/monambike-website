using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Platform
{
    public int PlatformId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Medium> Media { get; } = new List<Medium>();
}
