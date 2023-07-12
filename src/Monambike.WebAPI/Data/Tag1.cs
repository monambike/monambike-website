using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Tag1
{
    public int TagId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Word> Words { get; } = new List<Word>();
}
