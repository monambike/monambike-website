namespace Monambike.WebAPI.Data
{
    public class Address
    {
        public int Id { get; set; }

        public Country Country { get; set; }

        public string State { get; set; }

        public string CityProvince { get; set; }

        public string District { get; set; }

        public string Street { get; set; }

        public string StreetNumber { get; set; }

        public string PostalCode { get; set; }
    }
}
