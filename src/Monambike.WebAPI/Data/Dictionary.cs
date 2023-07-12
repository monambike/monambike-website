using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Dictionary
{
    public int DictionaryId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Theme> Themes { get; } = new List<Theme>();
}
