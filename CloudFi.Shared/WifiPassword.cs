namespace CloudFi.Shared
{
    public class WifiPassword
    {
        public int OwnerUserId { get; set; }
        public string Ssid { get; set; }
        public string Password { get; set; }

        public virtual User Owner { get; set; }
    }
}
