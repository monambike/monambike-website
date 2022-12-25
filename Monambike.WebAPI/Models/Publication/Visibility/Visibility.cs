namespace Monambike.WebAPI.Models.Publication.Visibility
{
    public enum Visibility
    {
        Public,
        Private,
        JustWithLink,
        LoggedUsers,
        SpecificLoggedUsers
    }

    //public abstract class Visibility
    //{
    //    public abstract byte[] Icon { get; }

    //    public string Name => GetType().Name;
    //}

    //public static class Visibility
    //{
    //    public static Base Public => new Base().Icon = 0;
    //    public static Base Private => new Base().Icon = 0;
    //    public static Base JustWithLink => new Base().Icon = 0;
    //    public static Base LoggedUsers => new Base().Icon = 0;
    //    public static Base SpecificUsers => new Base().Icon = 0;
    //}

    //public class Base
    //{
    //    public byte[] Icon { get; }

    //}

    //public class Public : Base { public override byte[] Icon => new byte[0]; }
    //public class Private : Base { public override byte[] Icon => new byte[0]; }
    //public class JustWithLink : Base { public override byte[] Icon => new byte[0]; }
    //public class LoggedUsers : Base { public override byte[] Icon => new byte[0]; }
    //public class SpecificUsers : Base { public override byte[] Icon => new byte[0]; }
}
