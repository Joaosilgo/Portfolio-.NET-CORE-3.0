using Microsoft.AspNetCore.Hosting;
//using WebApplication1.Data;

[assembly: HostingStartup(typeof(infoSys.Areas.Identity.IdentityHostingStartup))]
namespace infoSys.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}