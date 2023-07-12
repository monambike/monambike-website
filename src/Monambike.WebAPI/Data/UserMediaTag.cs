using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class UserMediaTag
{
    public int MediaId { get; set; }

    public int UserId { get; set; }

    public int UserTagId { get; set; }

    public virtual UserMedium UserMedium { get; set; } = null!;

    public virtual UserTag UserTag { get; set; } = null!;
}
