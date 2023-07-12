using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Language
{
    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public int CountryId { get; set; }

    public virtual Country Country { get; set; } = null!;
}
