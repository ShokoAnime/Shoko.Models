

using Shoko.Models.Server;

namespace Shoko.Models.WebCache
{
    public class WebCache_CrossRef_AniDB_TvDB_Request : CrossRef_AniDB_TvDBV2
    {
        public string AnimeName { get; set; }
        public string Username { get; set; }
        public string AuthGUID { get; set; }
    }
}