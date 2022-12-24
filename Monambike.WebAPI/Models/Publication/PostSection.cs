using Monambike.WebAPI.Models.Posting.Cards;
using System.Collections.Generic;

namespace Monambike.WebAPI.Models.Posting
{
    public class Topic
    {
        /// <summary>
        /// Website H2
        /// </summary>
        public string Title { get; set; }

        public List<Body> Body { get; set; } = new List<Body>
        {
            new Body("hello my friends"),
            new Body(0), // Image
            new Body(new Tip("be careful.."))
        };
    }

    public class Body
    {
        private object Content = null;

        public Body() { }
        public Body(string paragraph) { Content = paragraph; }
        public Body(byte image) { Content = image; }
        public Body(Caution caution) { Content = caution; }
        public Body(Note note) { Content = note; }
        public Body(Tip tip) { Content = tip; }
        public Body(Warning warning) { Content = warning; }
    }


    //public static class Body
    //{
    //    public static string BodyTest(string paragraph) => paragraph;
    //    public static byte BodyTest(byte image) => image;
    //    public static Caution BodyTest(Caution caution) => caution;
    //    public static Note BodyTest(Note note) => note;
    //    public static Tip BodyTest(Tip tip) => tip;
    //    public static Warning BodyTest(Warning warning) => warning;
    //}
}
