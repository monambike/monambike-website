using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Meaning
{
    public int WordId { get; set; }

    public string? Description { get; set; }

    public string? Example { get; set; }

    public virtual Word Word { get; set; } = null!;
}
