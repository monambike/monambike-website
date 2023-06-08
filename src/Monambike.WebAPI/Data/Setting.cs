using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Setting
{
    public int UserId { get; set; }

    public string PrimaryColor { get; set; } = null!;

    public string SecondaryColor { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
