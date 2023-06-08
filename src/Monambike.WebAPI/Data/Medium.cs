using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Data;

public partial class Medium
{
    public int MediaId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTimeOffset CreationDate { get; set; }

    public virtual ICollection<UserMedium> UserMedia { get; } = new List<UserMedium>();

    public virtual ICollection<Group> Groups { get; } = new List<Group>();

    public virtual ICollection<Platform> Platforms { get; } = new List<Platform>();

    public virtual ICollection<Progress> Progresses { get; } = new List<Progress>();

    public virtual ICollection<Tag> Tags { get; } = new List<Tag>();
}
