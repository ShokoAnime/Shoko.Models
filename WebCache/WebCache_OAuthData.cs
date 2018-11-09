using System;

namespace Shoko.Models.WebCache
{
    public class WebCache_OAuthData
    {
        public string Token { get; set; }
        public string OriginalRedirectUri { get; set; }
        public string Provider { get; set; }
        public string RedirectUri { get; set; }
    }
}