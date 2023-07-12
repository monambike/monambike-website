using System.Collections.Generic;

namespace Monambike.WebAPI.DTOs.Dictionary
{
    public record GetWordDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public List<string> Meanings { get; set; }
    }
}
