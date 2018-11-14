using System.Collections.Generic;

namespace CloudFi.Shared
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual List<WifiPassword> WifiPasswords { get; set; }
    }
}
