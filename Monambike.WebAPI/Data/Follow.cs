using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Follow
{
    public int FollowerId { get; set; }

    public int FollowedId { get; set; }

    public DateTimeOffset FollowDateTime { get; set; }

    public virtual User Followed { get; set; } = null!;

    public virtual User Follower { get; set; } = null!;
}
