using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class WordRelationType
{
    public int WordRelationTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<WordRelation> WordRelations { get; } = new List<WordRelation>();
}
