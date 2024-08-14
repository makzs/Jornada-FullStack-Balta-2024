using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Lazuli.Web;
using MudBlazor.Services;
using Lazuli.Core;
using Lazuli.Core.Handlers;
using Lazuli.Web.Handlers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();

builder.Services
    .AddHttpClient(WebConfiguration.HttpClientName,
    opt =>
    {
        opt.BaseAddress = new Uri(Configuration.BackendUrl);
    });

builder.Services.AddTransient<ICategoryHandler, CategoryHandler>();

await builder.Build().RunAsync();
