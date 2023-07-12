using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Progress
{
    public int Progress1 { get; set; }

    public string Name { get; set; } = null!;

    public int TypeId { get; set; }

    public virtual ICollection<MediaProgress> MediaProgresses { get; } = new List<MediaProgress>();

    public virtual Type Type { get; set; } = null!;

    public virtual ICollection<UserMedium> UserMedia { get; } = new List<UserMedium>();
}
