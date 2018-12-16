using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(CloudFi.Areas.Identity.IdentityHostingStartup))]
namespace CloudFi.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}