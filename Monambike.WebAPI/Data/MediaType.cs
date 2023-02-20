using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class MediaType
{
    public int MediaTypeId { get; set; }

    public string Name { get; set; } = null!;
}
