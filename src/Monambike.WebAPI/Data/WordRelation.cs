using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class WordRelation
{
    public int WordId { get; set; }

    public int ReferenceWordId { get; set; }

    public int WordRelationTypeId { get; set; }

    public virtual Word ReferenceWord { get; set; } = null!;

    public virtual Word Word { get; set; } = null!;

    public virtual WordRelationType WordRelationType { get; set; } = null!;
}
