using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Phone
{
    public int UserId { get; set; }

    public int CountryCodeId { get; set; }

    public string Ddd { get; set; } = null!;

    public string Number { get; set; } = null!;

    public int? CompletePhoneNumber { get; set; }

    public virtual User User { get; set; } = null!;
}
