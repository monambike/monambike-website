namespace Monambike.Web.Models
{
    /// <summary>
    /// Represents a video game.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Gets the title of the game.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets a brief comment about the game.
        /// </summary>
        public string BriefComment { get; }

        /// <summary>
        /// Gets the list of tags associated with the game.
        /// </summary>
        public List<Tag> Tags { get; }

        /// <summary>
        /// Gets the list of platforms the game was consumed on.
        /// </summary>
        public List<Platform> Platforms { get; }

        /// <summary>
        /// Gets the list of achievements highlighted together within the game.
        /// </summary>
        public List<Achievement> Achievements { get; }

        /// <summary>
        /// Gets the image path for the game's cover image.
        /// </summary>
        public string ImagePath { get; }

        /// <summary>
        /// Gets the total time played for the game.
        /// </summary>
        public TimeSpan TimePlayed { get; }

        /// <summary>
        /// Represents a tag associated with a game.
        /// </summary>
        public class Tag
        {
            /// <summary>
            /// Gets the name of the tag.
            /// </summary>
            public string Name { get; }
        }

        /// <summary>
        /// Represents a platform on which the game is available.
        /// </summary>
        public class Platform
        {
            /// <summary>
            /// Gets the name of the platform.
            /// </summary>
            public string Name { get; }

            /// <summary>
            /// Gets the color associated with the platform.
            /// </summary>
            public string Color { get; }
        }

        /// <summary>
        /// Represents an achievement within the game.
        /// </summary>
        public class Achievement
        {
            /// <summary>
            /// Gets the name of the achievement.
            /// </summary>
            public string Name { get; }

            /// <summary>
            /// Gets the description of the achievement.
            /// </summary>
            public string Description { get; }

            /// <summary>
            /// Gets the date and time when the achievement was awarded.
            /// </summary>
            public DateTime AwardedAt { get; }

            /// <summary>
            /// Gets the percentage of players who achieved this achievement.
            /// </summary>
            public float AchievedBy { get; }
        }
    }
}
