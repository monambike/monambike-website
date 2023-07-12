using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class MediaProgress
{
    public int MediaId { get; set; }

    public int ProgressId { get; set; }

    public int? UserId { get; set; }

    public virtual Medium Media { get; set; } = null!;

    public virtual Progress Progress { get; set; } = null!;
}
