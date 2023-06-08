using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Token
{
    public int TokenId { get; set; }

    public string Name { get; set; } = null!;

    public Guid CodeUid { get; set; }

    public DateTimeOffset ExpirationDate { get; set; }

    public DateTimeOffset CreationDate { get; set; }

    public int PostId { get; set; }

    public virtual Post Post { get; set; } = null!;
}
