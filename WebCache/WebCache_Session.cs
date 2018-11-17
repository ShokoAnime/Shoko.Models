using System;

namespace Shoko.Models.WebCache
{
    public class WebCache_Session
    {

        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public int AniDBUserId { get; set; }
        public string AniDBUserName { get; set; }
    }


}
