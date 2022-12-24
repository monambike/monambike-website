using System;
using System.Text.RegularExpressions;

namespace Monambike.WebAPI.Models
{
    public class Color
    {
        public Color(string hexadecimalColor) => HexadecimalColor = hexadecimalColor;

        private static readonly Regex hexadecimalColorRegex = new Regex(@"^#(?:[0-9a-fA-F]{3}){1,2}$", RegexOptions.Compiled);
        private string hexadecimalColor { get; set; }
        public string HexadecimalColor
        {
            get { return hexadecimalColor; }
            private set
            {
                Match match = hexadecimalColorRegex.Match($"#{value}");

                if (match.Success && value.Length == 6) hexadecimalColor = value;
                else throw new ArgumentException($@"""{value}"" is not a valid hexadecimal color.");
            }
        }
    }
}
