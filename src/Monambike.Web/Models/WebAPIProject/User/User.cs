using System;

namespace Common.WebAPI
{
    public class User
    {
        public Name Name { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Biography { get; set; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = DateTime.Today.Year - Birthday.Year;

                if (Birthday.Date > today.AddYears(-age)) age--;

                return age;
            }
        }

        public DateTime Birthday { get; set; }

        
        public string ProfilePicturePath { get; set; }

        public string ProfileBackgroundPath { get; set; }

    }

    public class Name
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Fullname => FirstName + SecondName;
    }
}
