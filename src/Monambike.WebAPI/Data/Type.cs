using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Type
{
    public int TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Medium> Media { get; } = new List<Medium>();

    public virtual ICollection<Progress> Progresses { get; } = new List<Progress>();
}
