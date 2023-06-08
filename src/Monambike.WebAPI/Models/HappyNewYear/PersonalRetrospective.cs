namespace Monambike.WebAPI.Models.HappyNewYear
{
    public class PersonalRetrospective
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string RelatedToAnotherPersonalRetrospective { get; set; }

        public string YearThatHappenend { get; set; }

        public Status Status { get; set; }
    }
    
    public enum Status { Done, Partial, Undone }
}
