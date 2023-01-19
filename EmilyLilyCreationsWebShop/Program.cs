using EmilyLilyCreationsWebShop;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

const string BaseImageUrl = "https://dalkeithgh.blob.core.windows.net/emilylilycreations/";

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://emilylilywebshop.azurewebsites.net/api/") });

await builder.Build().RunAsync();