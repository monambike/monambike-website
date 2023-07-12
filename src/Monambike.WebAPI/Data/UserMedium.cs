using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class UserMedium
{
    public int MediaId { get; set; }

    public int UserId { get; set; }

    public int? Rate { get; set; }

    public int ProgressOfMediaId { get; set; }

    public DateTimeOffset? LinkDate { get; set; }

    public virtual Medium Media { get; set; } = null!;

    public virtual Progress ProgressOfMedia { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual UserMediaTag? UserMediaTag { get; set; }
}
