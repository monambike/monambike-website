using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class UserMedium
{
    public int UserId { get; set; }

    public int MediaId { get; set; }

    public DateTimeOffset LinkDate { get; set; }

    public virtual Medium Media { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
