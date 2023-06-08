using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Progress
{
    public int ProgressId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Medium> Media { get; } = new List<Medium>();
}
