using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Word
{
    public int WordId { get; set; }

    public string Name { get; set; } = null!;

    public int? ThemeId { get; set; }

    public virtual Meaning? Meaning { get; set; }

    public virtual Theme? Theme { get; set; }

    public virtual ICollection<WordRelation> WordRelationReferenceWords { get; } = new List<WordRelation>();

    public virtual ICollection<WordRelation> WordRelationWords { get; } = new List<WordRelation>();

    public virtual ICollection<Tag1> TagOfWords { get; } = new List<Tag1>();
}
