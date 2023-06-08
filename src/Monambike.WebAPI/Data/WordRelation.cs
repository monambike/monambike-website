using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class WordRelation
{
    public int ReferenceId { get; set; }

    public int WordId { get; set; }

    public int RelationType { get; set; }

    public virtual Word Reference { get; set; } = null!;

    public virtual Word Word { get; set; } = null!;
}
