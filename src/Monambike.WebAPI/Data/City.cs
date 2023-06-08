using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class City
{
    public int CityId { get; set; }

    public string Name { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public int RegionId { get; set; }

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual Region Region { get; set; } = null!;
}
