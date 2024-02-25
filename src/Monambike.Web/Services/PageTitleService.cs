using Microsoft.JSInterop;
using Monambike.Core.Data;

namespace Monambike.Web.Services
{
    /// <summary>
    /// Provides functionality for manipulating the title of the current webpage.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="PageTitleService"/> class.
    /// </remarks>
    public class PageTitleService(IJSRuntime jsRuntime)
    {
        // Instance of Javascript runtime where calls may be dispatched
        private readonly IJSRuntime _jsRuntime = jsRuntime;

        // Current website name
        private readonly string WebsiteName = Core.Data.Monambike.Username;

        /// <summary>
        /// Sets the prefix on the title of the current webpage by setting it to
        /// a combination of the website name and the provided page title prefix.
        /// </summary>
        /// <param name="prefix">The prefix for the title on the specific page.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method uses JavaScript to update the title of the current webpage in the browser's
        /// document object. It combines the website name and the provided page title prefix to create
        /// a new title in the format: "{prefix} | {WebsiteName}".
        /// </remarks>
        public async Task SetPrefixOnPageTitle(string prefix)
        {
            // Use JavaScript runtime to execute a script that updates the document title.
            await _jsRuntime.InvokeVoidAsync("eval", $"document.title = '{prefix} | {WebsiteName}'");
        }
    }
}
