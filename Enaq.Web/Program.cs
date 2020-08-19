using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.IndexedDB.WebAssembly;
using Enaq.Web.Data;
using Enaq.Web.Services.Tabs;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Enaq.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddSingleton<IIndexedDbFactory, IndexedDbFactory>();
            builder.Services.AddSingleton<IDatabase, Database>();
            builder.Services.AddScoped<ITabRepository, TabRepository>();
            builder.Services.AddScoped<ITabsService, TabsService>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
