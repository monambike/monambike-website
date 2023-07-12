using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class UserTag
{
    public int UserTagId { get; set; }

    public string Name { get; set; } = null!;

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<UserMediaTag> UserMediaTags { get; } = new List<UserMediaTag>();
}
