using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Login
{
    public string Username { get; set; } = null!;

    public string? Email { get; set; }

    public byte[] Password { get; set; } = null!;

    public int? PhoneId { get; set; }

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
