using System;

namespace Shoko.Models.WebCache
{
    public class WebCache_OAuthAccessTokenWithState : WebCache_OAuthAccessToken
    {
        public string state { get; set; }

        public string error { get; set; }

    }
}
