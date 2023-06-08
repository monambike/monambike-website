using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Tag
{
    public int TagId { get; set; }

    public string Name { get; set; } = null!;

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Medium> Media { get; } = new List<Medium>();
}
