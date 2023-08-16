namespace Monambike.Web.Models
{
    public class SocialMedia
    {
        public string Name { get; }
        public string IconPath { get; }

        private static readonly string IconPathBase = "../../wwwroot/images/social-media/";

        /// <summary>
        /// Creates a new SocialMedia instance.
        /// </summary>
        /// <param name="name">The name of the social media.</param>
        /// <param name="iconFileName">The file name for the icon. Should be relative to the IconPathBase: "{IconPathBase}{iconFileName}".</param>
        public SocialMedia(string name, string iconFileName)
        {
            Name = name;
            IconPath = GetFullIconPath(iconFileName);
        }

        private static string GetFullIconPath(string iconFileName) => IconPathBase + iconFileName;

        public static SocialMedia GitHub => new("GitHub", "github.png");
        public static SocialMedia LinkedIn => new("LinkedIn", "linkedin.png");
        public static SocialMedia Instagram => new("Instagram", "instagram.png");
    }
}
