using System.Collections.Generic;

namespace Monambike.WebAPI.Models.Location
{
    public class Country
    {
        public string Name { get; set; }

        /// <summary>
        /// Example: Brazil it's "+55".
        /// </summary>
        public int CountryCode { get; set; }

        /// <summary>
        /// Example: Brazil it's "BR".
        /// </summary>
        public string ISOCode { get; set; }

        public List<State> States { get; set; }
    }
}
