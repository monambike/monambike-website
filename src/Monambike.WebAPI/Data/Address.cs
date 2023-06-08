using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Address
{
    public int UserId { get; set; }

    public string Street { get; set; } = null!;

    public string Number { get; set; } = null!;

    public int? CityId { get; set; }

    public int? RegionId { get; set; }

    public int? CountryId { get; set; }

    public virtual City? City { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Region? Region { get; set; }

    public virtual User User { get; set; } = null!;
}
