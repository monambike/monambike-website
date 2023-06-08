using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Group
{
    public int GroupId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int UserId { get; set; }

    public virtual User GroupNavigation { get; set; } = null!;

    public virtual ICollection<Medium> Media { get; } = new List<Medium>();
}
