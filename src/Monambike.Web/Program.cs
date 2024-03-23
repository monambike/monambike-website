// Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: contact @monambike.com for more information.
// For license information, please see the LICENSE file in the root directory.
using Monambike.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Monambike.Web.Services;
using Microsoft.AspNetCore.Builder;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources/Localization");
builder.Services.AddScoped<PageTitleService>();

string[] supportedCultures = ["en-US", "pt-BR"];
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

await builder.Build().RunAsync();
