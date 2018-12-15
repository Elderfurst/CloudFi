using CloudFi.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudFi
{
    public class CloudFiContext : DbContext
    {
        public CloudFiContext(DbContextOptions<CloudFiContext> options) : base(options)  { }

        public DbSet<WifiConfiguration> WifiConfigurations { get; set; }
    }
}
