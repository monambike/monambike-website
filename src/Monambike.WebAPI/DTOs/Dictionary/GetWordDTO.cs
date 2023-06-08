using System.Collections.Generic;

namespace Monambike.WebAPI.DTOs.Dictionary
{
    public class GetWordDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Meanings { get; set; }
    }
}
