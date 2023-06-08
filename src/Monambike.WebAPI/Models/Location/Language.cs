namespace Monambike.WebAPI.Models.Location
{
    public class Language
    {
        public string Name { get; set; }

        /// <summary>
        /// Example: Portuguese is "PT".
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// Example: Brazil it's "BR".
        /// </summary>
        public string CountryCode => Country.ISOCode;

        private Country Country { get; set; }
    }
}
