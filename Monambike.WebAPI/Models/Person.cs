using System;
using Monambike.WebAPI.Models.Address;

namespace Monambike.WebAPI.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public char Password { get; set; }


        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string FullName => $"{FirstName} {SecondName}";

        public string Biography { get; set; }

        public Phone Phone { get; set; }


        public byte ProfilePhoto { get; set; }

        public byte BackgroundPhoto { get; set; }


        public Address Address { get; set; }

        public DateTime Birthday { get; set; }

        public int Age => DateTime.Now.Year - Birthday.Year;
    }

    public class Phone
    {
        public Country Country { get; set; }

        private int CountryCode => Country.CountryCode;

        public string PhoneNumber { get; set; }

        public string FullPhoneNumber => $"+{CountryCode} {PhoneNumber}";
    }
}
