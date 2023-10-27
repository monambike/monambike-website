using System;

namespace Common.WebAPI.Models.User
{
    public class Login
    {
        public string LoginUsernameOrEmail { get; set; }

        public char PasswordAsChar { get; set; }

        public HashCode PasswordAsHashCode { get; set; }
    }
}
