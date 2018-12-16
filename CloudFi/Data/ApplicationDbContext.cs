using CloudFi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CloudFi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<WifiConfiguration> WifiConfigurations { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
