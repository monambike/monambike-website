namespace Monambike.WebAPI
{
    public class Game : Media
    {
        public override string GetConsumeStatus()
        {
            return ConsumeStatus switch
            {
                ConsumeStatus.Already => "",
                ConsumeStatus.Current => "",
                ConsumeStatus.WantTo => "",
                _ => "",
            };
        }
    }
}
