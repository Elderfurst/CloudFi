using System.ComponentModel.DataAnnotations;

namespace CloudFi.Models
{
    public class WifiConfiguration
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Ssid { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
