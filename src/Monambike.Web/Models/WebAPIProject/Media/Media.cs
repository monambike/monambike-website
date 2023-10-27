namespace Common.WebAPI
{
    public class Media
    {
        public string Name { get; set; }

        public string PathImage { get; set; }
    }

    public enum ConsumedMediaState { WannaConsume, Consuming, Consumed }
}
