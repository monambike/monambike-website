using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Comment
{
    public int CommentId { get; set; }

    public string Description { get; set; } = null!;

    public DateTimeOffset DateTime { get; set; }

    public int UserId { get; set; }

    public int PostId { get; set; }

    public virtual User CommentNavigation { get; set; } = null!;

    public virtual Post Post { get; set; } = null!;
}
