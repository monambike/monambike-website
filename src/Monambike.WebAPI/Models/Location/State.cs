using System.Collections.Generic;

namespace Monambike.WebAPI.Models.Location
{
    public class State
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public List<City> Cities { get; set; }
    }
}
