using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class User
{
    public int UserId { get; set; }

    public byte[]? Photo { get; set; }

    public string ExibitionName { get; set; } = null!;

    public string RealName { get; set; } = null!;

    public string? Status { get; set; }

    public string? Biography { get; set; }

    public virtual Address? Address { get; set; }

    public virtual Comment? Comment { get; set; }

    public virtual ICollection<Follow> FollowFolloweds { get; } = new List<Follow>();

    public virtual ICollection<Follow> FollowFollowers { get; } = new List<Follow>();

    public virtual Group? Group { get; set; }

    public virtual Login? Login { get; set; }

    public virtual Phone? Phone { get; set; }

    public virtual Setting? Setting { get; set; }

    public virtual ICollection<Tag> Tags { get; } = new List<Tag>();

    public virtual ICollection<UserMedium> UserMedia { get; } = new List<UserMedium>();
}
