using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Theme
{
    public int ThemeId { get; set; }

    public string Name { get; set; } = null!;

    public int DictionaryId { get; set; }

    public int? ParentThemeId { get; set; }

    public virtual Dictionary Dictionary { get; set; } = null!;

    public virtual ICollection<Theme> InverseParentTheme { get; } = new List<Theme>();

    public virtual Theme? ParentTheme { get; set; }

    public virtual ICollection<Word> Words { get; } = new List<Word>();
}
