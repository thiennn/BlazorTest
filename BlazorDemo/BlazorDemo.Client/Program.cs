using BlazorDemo.Client.Services;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDemo.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(configure =>
            {
                // Add any custom services here
                configure.Add(ServiceDescriptor.Singleton<IService, Service>());
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
