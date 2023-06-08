using System;

namespace Monambike.WebAPI.Models.Posting
{
    public class EditHistory
    {
        public Post Post { get; set; }

        public DateTime EditChangeTime { get; set; }
    }
}
