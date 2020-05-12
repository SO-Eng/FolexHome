using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace FolexHome
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();

            //builder.Services.AddTransient(sp => new HttpClient
            //{
            //    // TODO: Change this to correct address!
            //    //BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            //    BaseAddress = new Uri("https://testsytemapi.folex.io/")
            //});

            await builder.Build().RunAsync();
        }
    }
}
