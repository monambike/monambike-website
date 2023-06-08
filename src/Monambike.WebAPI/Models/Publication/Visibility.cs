using System.Text.Json.Serialization;

namespace Monambike.WebAPI.Models.Publication
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Visibility
    {
        Public,
        Private,
        JustWithToken,
        JustLoggedUsers,
        SpecificLoggedUsers
    }
}
