using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Country
{
    public int CountryId { get; set; }

    public string Name { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual ICollection<Region> Regions { get; } = new List<Region>();
}
