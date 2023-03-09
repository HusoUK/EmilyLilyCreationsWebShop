using EmilyLilyCreationsWebShop;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

const string BaseImageUrl = "https://dalkeithgh.blob.core.windows.net/emilylilycreations/";
string BaseApiUrl = Environment.GetEnvironmentVariable("API_url");
string BaseBlobUrl = Environment.GetEnvironmentVariable("BlobStorage_url");


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(BaseApiUrl) });

await builder.Build().RunAsync();