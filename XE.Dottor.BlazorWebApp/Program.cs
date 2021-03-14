namespace XE.Dottor.BlazorWebApp
{
    using Microsoft.AspNetCore.Components.Authorization;
    using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using XE.Dottor.ApplicationCore.Interfaces;
    using XE.Dottor.ApplicationCore.Services;
    using XE.Dottor.BlazorWebApp.Services;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddAuthorizationCore();
            
            builder.Services.AddSingleton<XeAuthenticationStateProvider>();
            builder.Services.AddSingleton<AuthenticationStateProvider>(provider => provider.GetRequiredService<XeAuthenticationStateProvider>());
            builder.Services.AddSingleton<StateContainer>();

            builder.Services.AddSingleton<IApiProxyService, JSONPlaceholderApiProxyService>();
            builder.Services.AddSingleton<JsFunctionService>();

            await builder.Build().RunAsync();
        }
    }
}
