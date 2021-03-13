namespace XE.Dottor.BlazorWebApp
{
    using Microsoft.AspNetCore.Components.Authorization;
    using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using XE.Dottor.ApplicationCore.Services;
    using XE.Dottor.BlazorWebApp.Services;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<XeAuthenticationStateProvider>();
            builder.Services.AddScoped<AuthenticationStateProvider>(provider => provider.GetRequiredService<XeAuthenticationStateProvider>());
            builder.Services.AddScoped<StateContainer>();
            builder.Services.AddScoped<JSONPlaceholderApiProxyService>();
            builder.Services.AddScoped<JsFunctionService>();

            await builder.Build().RunAsync();
        }
    }
}
