using Funq;
using ServiceStack;
using MatchingPlatformUI.ServiceInterface;

[assembly: HostingStartup(typeof(MatchingPlatformUI.AppHost))]

namespace MatchingPlatformUI;

public class AppHost : AppHostBase, IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            // Configure ASP.NET Core IOC Dependencies
        });

    public AppHost() : base("MatchingPlatformUI", typeof(MyServices).Assembly) {}

    public override void Configure(Container container)
    {
        // enable server-side rendering, see: https://sharpscript.net/docs/sharp-pages
        Plugins.Add(new SharpPagesFeature {
            EnableSpaFallback = true
        }); 

        SetConfig(new HostConfig {
            AddRedirectParamsToQueryString = true,
        });
    }
}
