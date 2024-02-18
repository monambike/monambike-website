using Notion.Client;

namespace Monambike.Web.Utilities
{
    internal class Notion
    {
        internal static void Test()
        {
            var client = NotionClientFactory.Create(new ClientOptions
            {
                AuthToken = Envi
            });

            var usersList = await client.Users.ListAsync();
        }
    }
}
