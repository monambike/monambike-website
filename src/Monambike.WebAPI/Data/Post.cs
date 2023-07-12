using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Post
{
    public int PostId { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public int VisibilityId { get; set; }

    public virtual ICollection<Comment> Comments { get; } = new List<Comment>();

    public virtual ICollection<Token> Tokens { get; } = new List<Token>();

    public virtual Visibility Visibility { get; set; } = null!;

    public virtual ICollection<Tag> TagOfPosts { get; } = new List<Tag>();
}
